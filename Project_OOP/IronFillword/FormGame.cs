using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace IronFillword
{

    public partial class FormGame : Form
    {
        int FieldSize;
        int[] FirstLetterPosition = { -1, -1 };
        int[] LastLetterPosition = { -1, -1 };
        int CountGuessedWords = 0;
        int CountOfAddedWords = 0;
        int seconds = 0;
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        List<String> TargetWords = new List<String>();
        public FormGame(int Size)
        {
            InitializeComponent();
            timerGuessedWords.Interval = 1000;
            FieldSize = Size;
        }

        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formmenu = new FormMenu();
            formmenu.Show();
        }

        private void labelTimer_Click(object sender, EventArgs e)
        {

        }
        private void timerGuessedWords_Tick(object sender, EventArgs e)
        {
            seconds++;
            labelTimer.Text = $"Рæстæг: {seconds} сек";
            if (seconds > 60)
            {
                labelTimer.Text = $"Рæстæг: {seconds/60} мин {seconds%60} сек";
            }
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

            GenerateGrid(FieldSize);
            CreateDict();
            PrintField();
            FillRandomLetters();
            timerGuessedWords.Start();
            
        }
        private void GenerateGrid(int FieldSize)
        {
            dataGridViewGameField.DefaultCellStyle.SelectionBackColor = Color.Gray;
            if (FieldSize == 8)
            {
                dataGridViewGameField.Size = new Size(400, 403);
                dataGridViewGameField.Location = new Point(19, 92);
                this.Size = new Size(950, 545);
                textBoxWordsList.Location = new Point(3, 22);
                textBoxWordsList.Size = new Size(345, 480);
                buttonCheckWord.Location = new Point(434, 372);
                buttonCheckWord.Size = new Size(121, 123);
                for (int i = 0; i < FieldSize; i++)
                {
                    var column = new DataGridViewTextBoxColumn();
                    column.Name = "Col" + i;
                    column.HeaderText = i.ToString();
                    column.Tag = i.ToString();
                    column.Width = 50;
                    var rows = new DataGridViewRow();
                    rows.Height = 50;
                    dataGridViewGameField.Columns.Add(column);
                    dataGridViewGameField.Rows.Add(rows);
                }
            }
            else 
            {
                dataGridViewGameField.Size = new Size(532, 604);
                dataGridViewGameField.Location = new Point(19,92);
                this.Size = new Size(1051,747);
                textBoxWordsList.Location = new Point(3, 22);
                textBoxWordsList.Size = new Size(345, 683);
                buttonCheckWord.Location = new Point(557, 573);
                buttonCheckWord.Size = new Size(121, 123);
                for (int i = 0; i < FieldSize; i++)
                {
                    var column = new DataGridViewTextBoxColumn();
                    column.Name = "Col" + i;
                    column.HeaderText = i.ToString();
                    column.Tag = i.ToString();
                    column.Width = 50;
                    var rows = new DataGridViewRow();
                    rows.Height = 50;
                    dataGridViewGameField.Columns.Add(column);
                    dataGridViewGameField.Rows.Add(rows);
                }
            }
        }
        private string[] LoadRandomWords(string FilePath) 
        {
            string[] words = File.ReadAllLines(FilePath);
            HashSet<string> rnwords = new HashSet<string>();
            Random rnd = new Random();
            for (int i = 0; i < 35; i++)
            {
                if (words[i].Length <= FieldSize)
                rnwords.Add(words[rnd.Next(words.Length)]);
            }
            string[] rndwords = new string[rnwords.Count];
            rnwords.CopyTo(rndwords);
            return rndwords;
        }
        private void PrintField()
        {
            PlaceWord(LoadRandomWords("OsetWords.txt"));
        }
        private int[] isVertical(string word)
        {
            int[] exit = { -1, -1 };
            for (int col = 0; col < FieldSize; col++)
            {
                int rowposition = 0;
                int count = 0;
                for (int row = rowposition; row < FieldSize; row++)
                {
                    if (dataGridViewGameField[col, row].Value == null)
                    {
                        if (count == 0)
                        {
                            rowposition = row;
                        }
                        count++;
                    }
                    if (count == word.Length)
                    {
                        exit[0] = rowposition;
                        exit[1] = col;
                        break;
                    }
                    else if (dataGridViewGameField[col, row].Value != null)
                    {
                        break;
                    }
                }
            }
            return exit;
        }
        private int[] isHorizontal(string word)
        {

            int[] exit = { -1, -1 };
            for (int row = 0; row < FieldSize; row++)
            {
                int colposition = 0;
                int count = 0;
                for (int col = colposition; col < FieldSize; col++)
                {
                    if (dataGridViewGameField[col, row].Value == null)
                    {
                        if (count == 0)
                        {
                            colposition = col;
                        }
                        count++;
                    }
                    if (count == word.Length)
                    {
                        exit[0] = colposition;
                        exit[1] = row;
                        break;
                    }
                    else if (dataGridViewGameField[col, row].Value != null)
                    {
                        break;
                    }
                }
            }
            return exit;
        }
        private bool PutWordInFieldHorizontal(string word, int[] position)
        {
            bool flag = true;
            int row = position[1];
            for (int col = position[0]; col < word.Length; col++)
            {
                if (dataGridViewGameField[col, row].Value != null)
                    flag = false;
            }
            for (int col = position[0]; col < word.Length; col++)
            {
                if (flag)
                dataGridViewGameField[col, row].Value = word[col];
            }
            return flag;
        }
        private bool PutWordInFieldVertical(string word, int[] position)
        {
            bool flag = true;
            int col = position[1];
            for (int row = position[0]; row < word.Length; row++)
            {
                if (dataGridViewGameField[col, row].Value != null)
                { flag = false; }
            }
            for (int row = position[0]; row < word.Length; row++)
            {
                if (flag)
                dataGridViewGameField[col, row].Value = word[row];
            }
            return flag;
        }
        private void PlaceWord(string[] words)
        {
            int click = 0;
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                if (isHorizontal(words[i])[1] != -1 && isHorizontal(words[i])[0] != -1 && isVertical(words[i])[0] != -1 && isVertical(words[i])[1] != -1)
                {
                    if (click % 2 == 0)
                    {
                        bool flag = PutWordInFieldHorizontal(words[i], isHorizontal(words[i]));
                        if (flag)
                        {
                            textBoxWordsList.Text += $"{words[i]} - {dictionary[words[i]]} \r\n";
                            TargetWords.Add(words[i]);
                            CountOfAddedWords++;
                            click++;
                        }
                    }
                    else
                    {
                        bool flag = PutWordInFieldVertical(words[i], isVertical(words[i]));
                        if (flag)
                        {
                            textBoxWordsList.Text += $"{words[i]} - {dictionary[words[i]]} \r\n";
                            TargetWords.Add(words[i]);
                            CountOfAddedWords++;
                            click++;
                        }
                    }
                }
                else if (isHorizontal(words[i])[1] != -1 && isHorizontal(words[i])[0] != -1)
                {
                    bool flag = PutWordInFieldHorizontal(words[i], isHorizontal(words[i]));
                    if (flag)
                    {
                        textBoxWordsList.Text += $"{words[i]} - {dictionary[words[i]]} \r\n";
                        TargetWords.Add(words[i]);
                        CountOfAddedWords++;
                    }
                }
                else if (isVertical(words[i])[0] != -1 && isVertical(words[i])[1] != -1)
                {
                    bool flag = PutWordInFieldVertical(words[i], isVertical(words[i]));
                    if (flag)
                    {
                        textBoxWordsList.Text += $"{words[i]} - {dictionary[words[i]]} \r\n";
                        TargetWords.Add(words[i]);
                        CountOfAddedWords++;
                    }
                }
            }
        }
        private void FillRandomLetters()
        {
            Random random = new Random();
            string abc = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭÆЯЧСМИТЬБЮ";
            for (int col = 0; col < FieldSize; col++)
            {
                for (int row = 0; row < FieldSize; row++)
                {
                    if (dataGridViewGameField[col, row].Value == null)
                    {
                        dataGridViewGameField[col, row].Value = abc[random.Next(33)];
                    }
                }
            }
        }
        private void DrawCellGreen(int[] FirstLetterPos, int[] LastLetterPos)
        {
            if (FirstLetterPos[0] == LastLetterPos[0])
            {
                for (int row = FirstLetterPos[1]; row <= LastLetterPos[1]; row++)
                {
                    dataGridViewGameField[FirstLetterPos[0], row].Style.BackColor = Color.Green;
                }
            }
            else if (FirstLetterPos[1] == LastLetterPos[1])
            {
                for (int col = FirstLetterPos[0]; col <= LastLetterPos[0]; col++)
                {
                    dataGridViewGameField[col, FirstLetterPos[1]].Style.BackColor = Color.Green;
                }
            }
        }
        private void DrawGrayToWhite() 
        {
            for (int col = 0; col < FieldSize; col++)
            {
                for(int row = 0; row < FieldSize; row++)
                {
                    if (dataGridViewGameField[col, row].Style.BackColor == Color.Gray)
                    {
                        dataGridViewGameField[col, row].Style.BackColor = Color.White;
                    }
                }
            }
        }
        private int CheckUserWord(int[] FirstLetterPos, int[] LastLetterPos, List<string> TargetWords)
        {
            string UserWord = "";
            try
            {
                if (FirstLetterPos[0] == LastLetterPos[0])
                {
                    for (int row = FirstLetterPos[1]; row <= LastLetterPos[1]; row++)
                    {
                        UserWord += (dataGridViewGameField[FirstLetterPos[0], row].Value.ToString());
                    }
                }
                else if (FirstLetterPos[1] == LastLetterPos[1])
                {
                    for (int col = FirstLetterPos[0]; col <= LastLetterPos[0]; col++)
                    {
                        UserWord += (dataGridViewGameField[col, FirstLetterPos[1]].Value.ToString());
                    }
                }

                else
                {
                    MessageBox.Show("Дамгъæте раст не равзæрстай!");
                    DrawGrayToWhite();
                    return -1;
                }
            }
            catch
            {
                MessageBox.Show("Дамгъæ равзар!");
                return -1;
            }
            for (int i = 0; i < TargetWords.Count; i++)
            {
                if (TargetWords[i] == UserWord)
                {
                    DrawCellGreen(FirstLetterPos, LastLetterPos);
                    CountGuessedWords += 1;
                    labelGuessedWords.Text = "Ссардтай:" + CountGuessedWords;
                    TargetWords.Remove(UserWord);
                    
                    return i;
                }                
            }
            MessageBox.Show("Ахæм дзырд нæй!");
            DrawGrayToWhite();
            //DrawCellRed(FirstLetterPos, LastLetterPos);
            return -1;
        }
        private void dataGridViewGameField_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewGameField.CurrentCell.Style.BackColor != Color.Green)
            {
                dataGridViewGameField.CurrentCell.Style.BackColor = Color.Gray;
                if (FirstLetterPosition[0] == -1 && FirstLetterPosition[1] == -1)
                {
                    FirstLetterPosition[0] = e.ColumnIndex;
                    FirstLetterPosition[1] = e.RowIndex;
                }
                LastLetterPosition[0] = e.ColumnIndex;
                LastLetterPosition[1] = e.RowIndex;
            }
        }
        private void buttonCheckWord_Click(object sender, EventArgs e)
        {
            CheckUserWord(FirstLetterPosition, LastLetterPosition, TargetWords);
            FirstLetterPosition[0] = -1;
            LastLetterPosition[0] = -1;
            FirstLetterPosition[1] = -1;
            LastLetterPosition[1] = -1;
            if (CountOfAddedWords == CountGuessedWords)
            {
                StreamWriter sw = new StreamWriter("Results.txt");
                timerGuessedWords.Stop();
                sw.WriteLine($"Рæстæг: {seconds}. Дзырдтæ: {CountGuessedWords}");
                sw.Close();
                var result = MessageBox.Show("Тынг хорз! Аллы дзырд базыдтай! \nНог хъазт райдайын?", "Рамбылдтай!", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    Close();
                }
                if (result == DialogResult.Yes)
                {
                    FormGame newForm = new FormGame(FieldSize);
                    newForm.Show();
                    this.Hide();
                }
            }
        }
        private void CreateDict()
        {
            string fileContent = File.ReadAllText("OsetWordsTranslate.txt");

            // Разделяем на строки
            string[] lines = fileContent.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { " – ", " - " }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = value;
                    }
                }
            }
        }
        private void dataGridViewGameField_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridViewGameField.CurrentCell.Style.BackColor != Color.Green)
            //{
            //    dataGridViewGameField.CurrentCell.Style.BackColor = Color.Gray;
            //    if (FirstLetterPosition[0] == -1 && FirstLetterPosition[1] == -1)
            //    {
            //        FirstLetterPosition[0] = e.ColumnIndex;
            //        FirstLetterPosition[1] = e.RowIndex;
            //    }
            //    LastLetterPosition[0] = e.ColumnIndex;
            //    LastLetterPosition[1] = e.RowIndex;
            //}
        }

        private void словарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRichTextBox formRichTextBox = new FormRichTextBox();
            formRichTextBox.Show();
        }

        private void результатыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormResult res = new FormResult();
            res.Show();
        }

        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Найдите все слова из списка на клеточном поле, заполненном буквами. Буквы можно выбирать щёлкнув мышью на первую, а затем последнюю буквы слова или" +
                "выбрав буквы последовательно. После того как выделили все буквы нажмите на кнопку <Афæлварын дзырд>. Слова расположены только горизонтально или вертикально. Удачи!", "Правила игры",
                MessageBoxButtons.OK);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это учебный проект студента СОГУ им.К.Л.Хетагурова\n" +
                "Габисова Георгия ПМ 11.1", "О программе",
                MessageBoxButtons.OK);
        }
    }
}
