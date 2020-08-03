using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Curvimeter
{
    /// <summary>
    /// Загрузка локализованных ресурсов
    /// </summary>
    public class Localization
    {
        /// <summary>
        /// Инициализируем менеджер ресурсов
        /// </summary>
        public  static CultureInfo[] GetCultures() {
            var cultures = new List<CultureInfo> {new CultureInfo("en")};
            var dir = Path.GetDirectoryName(Application.ExecutablePath);
            var files = Directory.GetFiles(dir, "*" + Extension);
            cultures.AddRange(files.Select(file => Path.GetFileName(file).Split('.')[0]).Select(name => new CultureInfo(name)));
            return cultures.ToArray();
        }
        private readonly Dictionary<string, string> _keys;
        private const string Extension = ".lng";

        public Localization(CultureInfo ci) 
        {
            var dir = Path.GetDirectoryName(Application.ExecutablePath);
            _keys = new Dictionary<string, string>();
            var file = Path.Combine(dir, ci.Name + Extension);
            if (!File.Exists(file)) return;
            var strings = File.ReadAllLines(file);
            foreach (var line in strings)
            {
                var kv = line.Split(new char[]{'='}, 2);
                if (kv.Length == 2) {
                    _keys.Add(kv[0], kv[1]);
                }
            }
        }
        
        /// <summary>
        /// Получение локализованной строки для текущей культуры.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="current">Текущая культура</param>
        /// <returns></returns>
        public string GetString(string key, string current)
        {
            return _keys.ContainsKey(key) ? _keys[key] : current;
        }
    }
}
