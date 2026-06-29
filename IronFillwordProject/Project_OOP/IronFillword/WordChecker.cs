using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronFillword
{
    internal class WordChecker
    {
        private DataGridView dataGridView;
        private List<string> targetWords;
        private int countGuessedWords;
        private int fieldSize;

        public WordChecker(DataGridView gridView, int size)
        {
            dataGridView = gridView;
            targetWords = new List<string>();
            countGuessedWords = 0;
            fieldSize = size;
        }

        public void SetTargetWords(List<string> words)
        {
            targetWords = new List<string>(words);
        }

        public bool CheckUserWord(int[] firstPos, int[] lastPos)
        {
            string userWord = ExtractWord(firstPos, lastPos);

            if (string.IsNullOrEmpty(userWord))
                return false;

            for (int i = 0; i < targetWords.Count; i++)
            {
                if (targetWords[i] == userWord)
                {
                    DrawCellGreen(firstPos,lastPos);
                    countGuessedWords++;
                    targetWords.RemoveAt(i);
                    return true;
                }
            }

            MessageBox.Show("Ахæм дзырд нæй!", "Ошибка", MessageBoxButtons.OK);
            ResetGrayToWhite();
            return false;
        }

        private string ExtractWord(int[] firstPos, int[] lastPos)
        {
            try
            {
                if (firstPos[0] == lastPos[0])
                {
                    string word = "";
                    for (int row = firstPos[1]; row <= lastPos[1]; row++)
                    {
                        word += dataGridView[firstPos[0], row].Value.ToString();
                    }
                    return word;
                }
                else if (firstPos[1] == lastPos[1])
                {
                    string word = "";
                    for (int col = firstPos[0]; col <= lastPos[0]; col++)
                    {
                        word += dataGridView[col, firstPos[1]].Value.ToString();
                    }
                    return word;
                }
                else
                {
                    MessageBox.Show("Дамгъæте раст не равзæрстай!", "Ошибка", MessageBoxButtons.OK);
                    ResetGrayToWhite();
                    return null;
                }
            }
            catch
            {
                MessageBox.Show("Дамгъæ равзар!", "Ошибка", MessageBoxButtons.OK);
                return null;
            }
        }

        private void ResetGrayToWhite()
        {
            for (int col = 0; col < fieldSize; col++)
            {
                for (int row = 0; row < fieldSize; row++)
                {
                    if (dataGridView[col, row].Style.BackColor == Color.Gray)
                    {
                        dataGridView[col, row].Style.BackColor = Color.White;
                    }
                }
            }
        }

        public void DrawCellGreen(int[] firstPos, int[] lastPos)
        {
            if (firstPos[0] == lastPos[0])
            {
                for (int row = firstPos[1]; row <= lastPos[1]; row++)
                {
                    dataGridView[firstPos[0], row].Style.BackColor = Color.Green;
                }
            }
            else if (firstPos[1] == lastPos[1])
            {
                for (int col = firstPos[0]; col <= lastPos[0]; col++)
                {
                    dataGridView[col, firstPos[1]].Style.BackColor = Color.Green;
                }
            }
        }

        public bool IsGameComplete(int totalWords)
        {
            return countGuessedWords == totalWords;
        }

        public int CountGuessedWords
        {
            get { return countGuessedWords; }
        }
        public void ResetGuessedWords()
        {
            countGuessedWords = 0;
        }
    }
}
