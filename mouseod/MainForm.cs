using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Win32;
using mouseod.Properties;
using System.Diagnostics;
using System.IO;
using System.ComponentModel;

namespace mouseod
{
    public partial class MainForm : Form
    {
        #region Variables
        bool isMousepres;
        bool isCtrl;
        string helpfile = "index.html";
        string siteUrl = "https://github.com/vkorotenko/mouse/wiki/Home";
        string donateUrl = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=3KREUUVLXCGT6";
        double baseDistance;
        double currentDistance;
        MouseHolder _mh;
        #endregion
        public MainForm()
        {
            baseDistance = 0;
            currentDistance = 0;
            InitializeComponent();
        }
        Settings Settings { get { return Settings.Default; } }
        private void onTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = onTopToolStripMenuItem.Checked;
            Settings.OnTop = TopMost;
            Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startWithWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var valuename = "mouseod.exe";
            var keyname = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
            Settings.StartWithWindows = startWithWindowsToolStripMenuItem.Checked;
            var rk = Registry.CurrentUser.OpenSubKey(keyname, true);
            if (Settings.StartWithWindows)
            {
                var path = Application.ExecutablePath;
                rk.SetValue(valuename, path);
            }
            else
            {
                rk.DeleteValue(valuename);
            }
            rk.Close();
            Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _mh = new MouseHolder(Settings.Default.Total);
            TopMost = Settings.OnTop;
            onTopToolStripMenuItem.Checked = TopMost;
            startWithWindowsToolStripMenuItem.Checked = Settings.StartWithWindows;
            meterOrInchToolStripMenuItem.Checked = Settings.IsMeter;
            FillLanguageMenu();

            hideToolStripMenuItem.Checked = Settings.Hide;
            if (hideToolStripMenuItem.Checked)
                Hide();
            baseBox.Text = Settings.BaseFx.ToString();
            Localize();
            resultLabel.Text = string.Empty;
            SetTotalLabel();
        }

        private void FillLanguageMenu()
        {
            AddCulture("en");
            AddCulture("ru");
            languageToolStripMenuItem.Enabled = true;
        }
        void AddCulture(string name) {
            var culture = new CultureInfo(name);
            var menuitem = new ToolStripMenuItem(culture.DisplayName);
            menuitem.Tag = culture;

            if (Settings.Language == culture.Name)
                menuitem.Checked = true;
            menuitem.Click += new EventHandler(menuitem_Click);
            languageToolStripMenuItem.DropDownItems.Add(menuitem);
        }
        void menuitem_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            if (menuItem != null)
            {
                var menu = languageToolStripMenuItem;
                foreach (ToolStripMenuItem item in menu.DropDownItems)
                {
                    item.Checked = false;
                }
                menuItem.Checked = true;
                Settings.Language = ((CultureInfo)menuItem.Tag).Name;
                Save();
                Localize();
            }
        }

        private void Localize()
        {
            var localization = new Localization(new CultureInfo(Settings.Language));

            Text = localization.GetString("FormTitle", Text);
            fileToolStripMenuItem.Text = localization.GetString("FileMenu",
                fileToolStripMenuItem.Text);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new About();
            form.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Settings.Default.Total = _mh.Total;
            Save();
        }

        private void meterOrInchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.IsMeter = meterOrInchToolStripMenuItem.Checked;
            Save();
        }

        #region MouseHook
        private void globalEventProvider_MouseMoveExt(object sender, Gma.UserActivityMonitor.MouseEventExtArgs e)
        {
            labelX.Text = e.X.ToString();
            labelY.Text = e.Y.ToString();
            var d = _mh.Add(e.X, e.Y);
            if (isMousepres && !isCtrl)
            {
                currentDistance += d;
                currentLabel.Text = currentDistance.ToString("0");
            }
            if (isMousepres && isCtrl)
            {
                baseDistance += d;
                baseLabel.Text = baseDistance.ToString("0");
            }

            SetTotalLabel();
            var res = (currentDistance / baseDistance) * Settings.BaseFx;
            resultLabel.Text = res.ToString();
            SetTotalLabel();
        }
        void SetTotalLabel()
        {
            if (!meterOrInchToolStripMenuItem.Checked)
                totalLabel.Text = _mh.Santimeter.ToString("0.00");
            else
                totalLabel.Text = _mh.Inches.ToString("0.00");
        }
        private void globalEventProvider_MouseDown(object sender, MouseEventArgs e)
        {
            isMousepres = true;
        }

        private void globalEventProvider_MouseUp(object sender, MouseEventArgs e)
        {
            isMousepres = false;
        }
        #endregion

        #region KeyboardHook

        private void globalEventProvider_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.RControlKey || e.KeyCode == Keys.LControlKey)
                isCtrl = true;

        }

        private void globalEventProvider_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.RControlKey || e.KeyCode == Keys.LControlKey)
                isCtrl = false;
        }

        #endregion

        #region Clear button handler
        private void currentButton_Click(object sender, EventArgs e)
        {
            currentDistance = 0;
            currentLabel.Text = 0.ToString();
        }

        private void baseButton_Click(object sender, EventArgs e)
        {
            baseDistance = 0;
            baseLabel.Text = 0.ToString();
        }

        #endregion

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Hide = hideToolStripMenuItem.Checked;
            Hide();
            showToolStripMenuItem.Enabled = true;
            Save();
        }

        private void Save()
        {
            Settings.Default.Save();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            showToolStripMenuItem.Enabled = false;
        }

        private void baseBox_TextChanged(object sender, EventArgs e)
        {
            double result = 1;
            if (double.TryParse(baseBox.Text, out result))
            {
                Settings.BaseFx = result;
                Save();
            }
        }

        private void contextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            var path = Path.GetDirectoryName(Application.ExecutablePath);
            proc.StartInfo = new ProcessStartInfo(Path.Combine(path, helpfile));
            try
            {
                proc.Start();
            }
            catch (Win32Exception ex)
            {
                // Нет файла :(
            }
        }

        private void homeSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            var path = Path.GetDirectoryName(Application.ExecutablePath);
            proc.StartInfo = new ProcessStartInfo(siteUrl);
            proc.Start();
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            var path = Path.GetDirectoryName(Application.ExecutablePath);
            proc.StartInfo = new ProcessStartInfo(donateUrl);
            proc.Start();
        }
    }
}
