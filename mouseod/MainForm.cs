using Curvimeter.Properties;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Curvimeter;

namespace Curvimeter
{
    public partial class MainForm : Form
    {
        #region Variables

        private bool _isMousepres;
        private bool _isCtrl;
        private string _helpfile = "index.html";
        private string _siteUrl = "https://github.com/vkorotenko/mouse";
        private string _donateUrl = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=3KREUUVLXCGT6";
        private double _baseDistance;
        private double _currentDistance;
        private MouseHolder _mh;
        #endregion
        public MainForm()
        {
            _baseDistance = 0;
            _currentDistance = 0;
            InitializeComponent();
        }

        private static Settings Settings => Settings.Default;

        private void OnTopToolStripMenuItemClick(object sender, EventArgs e)
        {
            TopMost = onTopToolStripMenuItem.Checked;
            Settings.OnTop = TopMost;
            Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void StartWithWindowsClick(object sender, EventArgs e)
        {

            const string exeName = "mouseod.exe";
            const string windowsCurrentVersionRun = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
            Settings.StartWithWindows = startWithWindowsToolStripMenuItem.Checked;
            var rk = Registry.CurrentUser.OpenSubKey(windowsCurrentVersionRun, true);
            if (rk == null) return;
            if (Settings.StartWithWindows)
            {
                var path = Application.ExecutablePath;
                rk.SetValue(exeName, path);
            }
            else
            {
                rk.DeleteValue(exeName);
            }
            rk.Close();
            Save();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            _mh = new MouseHolder(Settings.Default.Total);
            TopMost = Settings.OnTop;
            onTopToolStripMenuItem.Checked = TopMost;
            startWithWindowsToolStripMenuItem.Checked = Settings.StartWithWindows;
            meterOrInchToolStripMenuItem.Checked = Settings.IsMeter;
            SetLengthLabel();
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
            var path = Application.ExecutablePath;
            var dir = Path.GetDirectoryName(path);
            var satellite = "mouseod.resources.dll";
            AddCulture("en");
            if (File.Exists(Path.Combine(dir, "RU\\" + satellite)))
                AddCulture("ru");
            if (File.Exists(Path.Combine(dir, "FR\\" + satellite)))
                AddCulture("fr");
            languageToolStripMenuItem.Enabled = true;
        }

        private void AddCulture(string name)
        {
            var culture = new CultureInfo(name);
            var menuitem = new ToolStripMenuItem(culture.DisplayName) { Tag = culture };

            if (Settings.Language == culture.Name)
                menuitem.Checked = true;
            menuitem.Click += new EventHandler(LanguageMenuClick);
            languageToolStripMenuItem.DropDownItems.Add(menuitem);
        }

        private void LanguageMenuClick(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            if (menuItem == null) return;
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

        private void Localize()
        {
            var localization = new Localization(new CultureInfo(Settings.Language));

            Text = localization.GetString("FormTitle", Text);
            fileToolStripMenuItem.Text = localization.GetString("FileMenu",
                fileToolStripMenuItem.Text);

        }

        private void AboutItemClick(object sender, EventArgs e)
        {
            var form = new About();
            form.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Settings.Default.Total = _mh.Total;
            Save();
        }

        private void MeterOrInchItemClick(object sender, EventArgs e)
        {
            Settings.IsMeter = meterOrInchToolStripMenuItem.Checked;
            SetLengthLabel();
            SetTotalLabel();
            Save();
        }

        private void SetLengthLabel()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            totalLengthLabel.Text = resources.GetString(!Settings.IsMeter ? "totalLengthLabelInch.Text" : "totalLengthLabel.Text");
        }
        #region MouseHook
        private void globalEventProvider_MouseMoveExt(object sender, Gma.UserActivityMonitor.MouseEventExtArgs e)
        {
            labelX.Text = e.X.ToString();
            labelY.Text = e.Y.ToString();
            var d = _mh.Add(e.X, e.Y);
            if (_isMousepres && !_isCtrl)
            {
                _currentDistance += d;
                currentLabel.Text = _currentDistance.ToString("0");
            }
            if (_isMousepres && _isCtrl)
            {
                _baseDistance += d;
                baseLabel.Text = _baseDistance.ToString("0");
            }

            var res = (_currentDistance / _baseDistance) * Settings.BaseFx;
            resultLabel.Text = res.ToString();
            SetTotalLabel();
        }

        private void SetTotalLabel()
        {
            if (!meterOrInchToolStripMenuItem.Checked)
                totalLabel.Text = _mh.Santimeter.ToString("0.00");
            else
                totalLabel.Text = _mh.Inches.ToString("0.00");
        }
        private void globalEventProvider_MouseDown(object sender, MouseEventArgs e)
        {
            _isMousepres = true;
        }

        private void globalEventProvider_MouseUp(object sender, MouseEventArgs e)
        {
            _isMousepres = false;
        }
        #endregion

        #region KeyboardHook

        private void globalEventProvider_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.RControlKey || e.KeyCode == Keys.LControlKey)
                _isCtrl = true;

        }

        private void globalEventProvider_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.RControlKey || e.KeyCode == Keys.LControlKey)
                _isCtrl = false;
        }

        #endregion

        #region Clear button handler
        private void currentButton_Click(object sender, EventArgs e)
        {
            _currentDistance = 0;
            currentLabel.Text = 0.ToString();
        }

        private void baseButton_Click(object sender, EventArgs e)
        {
            _baseDistance = 0;
            baseLabel.Text = 0.ToString();
        }

        #endregion

        private void HideItemClick(object sender, EventArgs e)
        {
            Settings.Hide = hideToolStripMenuItem.Checked;
            Hide();
            showToolStripMenuItem.Enabled = true;
            Save();
        }

        private static void Save()
        {
            Settings.Default.Save();
        }

        private void ExitApplicationClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowItemClick(object sender, EventArgs e)
        {
            Show();
            showToolStripMenuItem.Enabled = false;
        }

        private void BaseBoxTextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(baseBox.Text, out var result)) return;
            Settings.BaseFx = result;
            Save();
        }

        private void ShowHelpClick(object sender, EventArgs e)
        {
            var proc = new Process();
            var path = Path.GetDirectoryName(Application.ExecutablePath);
            proc.StartInfo = new ProcessStartInfo(Path.Combine(path, _helpfile));
            try
            {
                proc.Start();
            }
            catch (Win32Exception ex)
            {
                Debug.WriteLine("No help file", ex);
            }
        }

        private void HomeSiteItemClick(object sender, EventArgs e)
        {
            new Process { StartInfo = new ProcessStartInfo(_siteUrl) }.Start();
        }

        private void DonateClick(object sender, EventArgs e)
        {
            new Process {StartInfo = new ProcessStartInfo(_donateUrl)}.Start();
        }
    }
}
