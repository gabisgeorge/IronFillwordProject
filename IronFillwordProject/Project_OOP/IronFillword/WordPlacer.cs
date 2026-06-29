using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronFillword
{
    internal class WordPlacer
    {
        private DataGridView dataGridView;
        private Dictionary<string, string> dictionary;
        private List<string> targetWords;
        private int countOfAddedWords;
        private int fieldSize;

        public WordPlacer(DataGridView gridView, Dictionary<string, string> dict, int size)
        {
            dataGridView = gridView;
            dictionary = dict;
            targetWords = new List<string>();
            countOfAddedWords = 0;
            fieldSize = size;
        }

        public int PlaceWords(string[] words, TextBox textBoxWordsList)
        {
            int click = 0;
            targetWords.Clear();
            countOfAddedWords = 0;

            for (int i = 0; i < words.Length; i++)
            {
                bool placed = TryPlaceWord(words[i], ref click);
                if (placed)
                {
                    textBoxWordsList.Text += $"{words[i]} - {dictionary[words[i]]} \r\n";
                    targetWords.Add(words[i]);
                    countOfAddedWords++;
                }
            }

            return countOfAddedWords;
        }

        private bool TryPlaceWord(string word, ref int click)
        {
            var horizontalPos = IsHorizontal(word);
            var verticalPos = IsVertical(word);

            bool hasHorizontal = horizontalPos[0] != -1 && horizontalPos[1] != -1;
            bool hasVertical = verticalPos[0] != -1 && verticalPos[1] != -1;

            if (hasHorizontal && hasVertical)
            {
                if (click % 2 == 0)
                {
                    return PutWordInFieldHorizontal(word, horizontalPos);
                }
                else
                {
                    click++;
                    return PutWordInFieldVertical(word, verticalPos);
                }
            }
            else if (hasHorizontal)
            {
                return PutWordInFieldHorizontal(word, horizontalPos);
            }
            else if (hasVertical)
            {
                return PutWordInFieldVertical(word, verticalPos);
            }

            return false;
        }

        public int[] IsHorizontal(string word)
        {
            int[] exit = { -1, -1 };
            for (int row = 0; row < fieldSize; row++)
            {
                int colPosition = 0;
                int count = 0;
                for (int col = colPosition; col < fieldSize; col++)
                {
                    if (dataGridView[col, row].Value == null)
                    {
                        if (count == 0) colPosition = col;
                        count++;
                    }
                    if (count == word.Length)
                    {
                        exit[0] = colPosition;
                        exit[1] = row;
                        return exit;
                    }
                    else if (dataGridView[col, row].Value != null)
                    {
                        break;
                    }
                }
            }
            return exit;
        }

        public int[] IsVertical(string word)
        {
            int[] exit = { -1, -1 };
            for (int col = 0; col < fieldSize; col++)
            {
                int rowPosition = 0;
                int count = 0;
                for (int row = rowPosition; row < fieldSize; row++)
                {
                    if (dataGridView[col, row].Value == null)
                    {
                        if (count == 0) rowPosition = row;
                        count++;
                    }
                    if (count == word.Length)
                    {
                        exit[0] = rowPosition;
                        exit[1] = col;
                        return exit;
                    }
                    else if (dataGridView[col, row].Value != null)
                    {
                        break;
                    }
                }
            }
            return exit;
        }

        private bool PutWordInFieldHorizontal(string word, int[] position)
        {
            int row = position[1];

            for (int col = position[0]; col < position[0] + word.Length; col++)
            {
                if (dataGridView[col, row].Value != null)
                    return false;
            }

            for (int col = position[0]; col < position[0] + word.Length; col++)
            {
                dataGridView[col, row].Value = word[col - position[0]];
            }

            return true;
        }

        private bool PutWordInFieldVertical(string word, int[] position)
        {
            int col = position[1];

            for (int row = position[0]; row < position[0] + word.Length; row++)
            {
                if (dataGridView[col, row].Value != null)
                    return false;
            }

            for (int row = position[0]; row < position[0] + word.Length; row++)
            {
                dataGridView[col, row].Value = word[row - position[0]];
            }

            return true;
        }

        public List<string> TargetWords
        {
            get { return targetWords; }
        }

        public int CountOfAddedWords
        {
            get { return countOfAddedWords; }
        }
    }
}
