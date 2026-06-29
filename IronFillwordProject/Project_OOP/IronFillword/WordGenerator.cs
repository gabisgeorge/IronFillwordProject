using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IronFillword
{
    internal class WordGenerator
    {
        private string WordsFilePath = "Resourses\\OsetWords.txt";

        public string[] LoadRandomWords(int maxWordLength, int count)
        {
            string[] allWords = File.ReadAllLines(WordsFilePath);
            HashSet<string> selectedWords = new HashSet<string>();
            Random rnd = new Random();

            for (int i = 0; i < count && selectedWords.Count < count; i++)
            {
                string word = allWords[rnd.Next(allWords.Length)];
                if (word.Length <= maxWordLength)
                {
                    selectedWords.Add(word);
                }
            }

            string[] result = new string[selectedWords.Count];
            selectedWords.CopyTo(result);
            return result;
        }
    }
}
