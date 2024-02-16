using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CalculoFormsApp.Properties
{
    static class idioma
    {
        public static Dictionary<string, string> info = new Dictionary<string, string>();

        public static void Load(string file)
        {
            info.Clear();

            foreach(string line in File.ReadLines("lang\\" + file))
            {
                if (line.Contains("="))
                {
                    string[] parts = line.Split(new char[] { '=' });
                    info.Add(parts[0], parts[1]);
                }
            }
        }

        public static void changeLanguage(string file)
        { 
            Properties.Settings config = new Properties.Settings();
            config.lang = file;
            config.Save();
            Load(file);
        }
    }
}
