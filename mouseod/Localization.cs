using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Globalization;
using mouseod.Properties;
using System.IO;
using System.Windows.Forms;

namespace mouseod
{
    /// <summary>
    /// Загрузка локализованных ресурсов
    /// </summary>
    public class Localization
    {
        /// Инициализируем менеджер ресурсов
        /// </summary>
        public  static CultureInfo[] GetCultures() {
            var cultures = new List<CultureInfo>();
            cultures.Add(new CultureInfo("en"));
            var dir = Path.GetDirectoryName(Application.ExecutablePath);
            var files = Directory.GetFiles(dir, "*" + _extension);
            foreach (var file in files)
            {
                var name = Path.GetFileName(file).Split('.')[0];
                cultures.Add(new CultureInfo(name));
            }
            return cultures.ToArray();
        }
        private Dictionary<string, string> _keys;
        private static string _extension=".lng";
        public Localization(CultureInfo ci) 
        {
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            _keys = new Dictionary<string, string>();
            var file = Path.Combine(dir, ci.Name + _extension);
            if (File.Exists(file)) {
                var strings = File.ReadAllLines(file);
                foreach (var line in strings)
                {
                    var kv = line.Split(new char[]{'='}, 2);
                    if (kv.Length == 2) {
                        _keys.Add(kv[0], kv[1]);
                    }
                }
            }
        }
        
        /// <summary>
        /// Получение локализованной строки для текущей культуры.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetString(string key, string current) {
            if (_keys.ContainsKey(key)) 
                return _keys[key];
            else
                return current;
        }
    }
}
