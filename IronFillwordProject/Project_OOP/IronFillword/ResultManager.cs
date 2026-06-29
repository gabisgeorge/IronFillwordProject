using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronFillword
{
    internal class ResultManager
    {
        private string ResultsFilePath = "Resourses\\Results.txt";

        public void SaveResult(int seconds, int wordsCount)
        {
            using (StreamWriter sw = new StreamWriter(ResultsFilePath))
            {
                sw.WriteLine($"Рæстæг: {seconds}. Дзырдтæ: {wordsCount}");
            }
        }

        public string[] LoadResults()
        {
            if (File.Exists(ResultsFilePath))
            {
                return File.ReadAllLines(ResultsFilePath);
            }
            return new string[] { "Нет результатов" };
        }
    }
}
