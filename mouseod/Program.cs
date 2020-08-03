#region License
// // Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// // email: koroten@ya.ru
// // skype:vladimir-korotenko
// // https://vkorotenko.ru
// // Создано:  03.08.2020 8:14
#endregion

using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Curvimeter.Properties;


namespace Curvimeter
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {

            if (!string.IsNullOrEmpty(Settings.Default.Language))
            {
                var language = Settings.Default.Language;
                try
                {
                    var cultureInfo = new CultureInfo(language);
                    Thread.CurrentThread.CurrentUICulture = cultureInfo;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("start error", ex);
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new MainForm();
            Application.Run(form);
        }
    }
}
