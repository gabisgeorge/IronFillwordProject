using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IronFillword
{
    internal class DictionaryManager
    {
        private Dictionary<string, string> dictionary;

        public DictionaryManager()
        {
            dictionary = new Dictionary<string, string>();
        }

        public void LoadDictionary(string filePath)
        {
            dictionary.Clear();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { " – ", " - " }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 2)
                {
                    string key = parts[0];
                    string value = parts[1];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = value;
                    }
                }
            }
        }

        public string GetTranslation(string word)
        {
            if (dictionary.ContainsKey(word))
            {
                return dictionary[word]; // Возвращаем перевод
            }
            else
            {
                return string.Empty; // Возвращаем пустую строку
            }
        }

        public Dictionary<string, string> Dictionary
        {
            get { return dictionary; }
        }
    }
}
