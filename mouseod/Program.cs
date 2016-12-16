using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using mouseod.Properties;
using System.IO;

namespace mouseod
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            if (!string.IsNullOrEmpty(Settings.Default.Language)) {
                var language = Settings.Default.Language;
                try {
                    var cultureInfo = new CultureInfo(language);
                    Thread.CurrentThread.CurrentUICulture = cultureInfo;
                }
                catch(Exception){
                }
            }
            
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new MainForm();
            Application.Run(form);
        }
        
        
    }
}
