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
        private WordPlacer wordPlacer;
        private WordChecker wordChecker;
        private DictionaryManager dictionaryManager;
        private WordGenerator wordGenerator;
        private GameUIHelper uiHelper;
        private ResultManager resultManager;

        private int[] firstLetterPosition = { -1, -1 };
        private int[] lastLetterPosition = { -1, -1 };
        private int totalWords = 0;
        private int seconds = 0;
        private int fieldSize;

        public FormGame(int size)
        {
            InitializeComponent();
            fieldSize = size;
            InitializeGameComponents();
        }

        private void InitializeGameComponents()
        {
            dictionaryManager = new DictionaryManager();
            dictionaryManager.LoadDictionary("Resourses\\OsetWordsTranslate.txt");

            uiHelper = new GameUIHelper(dataGridViewGameField);
            uiHelper.InitializeGrid(fieldSize);
            uiHelper.SetupFormSize(this, fieldSize, textBoxWordsList, buttonCheckWord);

            wordGenerator = new WordGenerator();
            resultManager = new ResultManager();
            
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void StartNewGame()
        {

            timerGuessedWords.Stop();

            ResetSelection();


            seconds = 0;
            labelTimer.Text = "Рæстæг: 0";
            labelGuessedWords.Text = "Ссардтай: 0";


            textBoxWordsList.Clear();


            dataGridViewGameField.Columns.Clear();
            dataGridViewGameField.Rows.Clear();


            uiHelper.InitializeGrid(fieldSize);
            uiHelper.SetupFormSize(this, fieldSize, textBoxWordsList, buttonCheckWord);


            wordPlacer = new WordPlacer(dataGridViewGameField, dictionaryManager.Dictionary, fieldSize);
            wordChecker = new WordChecker(dataGridViewGameField, fieldSize);


            var words = wordGenerator.LoadRandomWords(fieldSize, 35);
            totalWords = wordPlacer.PlaceWords(words, textBoxWordsList);


            uiHelper.FillRandomLetters(fieldSize);


            wordChecker.SetTargetWords(wordPlacer.TargetWords);
            wordChecker.ResetGuessedWords();


            timerGuessedWords.Start();
        }


        private void timerGuessedWords_Tick(object sender, EventArgs e)
        {
            seconds++;
            labelTimer.Text = seconds > 60
                ? $"Рæстæг: {seconds / 60} мин {seconds % 60} сек"
                : $"Рæстæг: {seconds} сек";
        }

        private void labelTimer_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewGameField_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            uiHelper.SetCellGray(e.ColumnIndex, e.RowIndex);

            if (firstLetterPosition[0] == -1 && firstLetterPosition[1] == -1)
            {
                firstLetterPosition[0] = e.ColumnIndex;
                firstLetterPosition[1] = e.RowIndex;
            }

            lastLetterPosition[0] = e.ColumnIndex;
            lastLetterPosition[1] = e.RowIndex;
        }

        private void dataGridViewGameField_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonCheckWord_Click(object sender, EventArgs e)
        {
            // Проверяем выбраны ли буквы
            if (firstLetterPosition[0] == -1 || lastLetterPosition[0] == -1)
            {
                MessageBox.Show("Равзарут дамгъæтæ!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            bool isCorrect = wordChecker.CheckUserWord(firstLetterPosition, lastLetterPosition);

            if (isCorrect)
            {
                labelGuessedWords.Text = $"Ссардтай: {wordChecker.CountGuessedWords}";
            }

            ResetSelection();

            if (wordChecker.IsGameComplete(totalWords))
            {
                FinishGame();
            }
        }

        private void ResetSelection()
        {
            firstLetterPosition[0] = -1;
            firstLetterPosition[1] = -1;
            lastLetterPosition[0] = -1;
            lastLetterPosition[1] = -1;
        }

        private void FinishGame()
        {
            timerGuessedWords.Stop();
            resultManager.SaveResult(seconds, wordChecker.CountGuessedWords);

            var result = MessageBox.Show(
                "Тынг хорз! Аллы дзырд базыдтай! \nНог хъазт райдайын?",
                "Рамбылдтай!",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                Close();
            }
            else if (result == DialogResult.Yes)
            {
                StartNewGame();
                timerGuessedWords.Start();
            }
        }

        // Обработчик для пункта "Ног хъазт"
        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
            "Ног хъазт райдайын?",
            "Ног хъазт",
            MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                StartNewGame();
            }
        }

        private void словарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dictForm = new FormRichTextBox();
            dictForm.Show();
        }

        private void результатыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var resultForm = new FormResult();
            resultForm.Show();
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Найдите все слова из списка на клеточном поле, заполненном буквами. Буквы можно выбирать щёлкнув мышью на первую, а затем последнюю буквы слова или " +
                "выбрав буквы последовательно. После того как выделили все буквы нажмите на кнопку <Афæлварын дзырд>. Слова расположены только горизонтально или вертикально. Удачи!",
                "Правила игры",
                MessageBoxButtons.OK);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Это учебный проект студента СОГУ им.К.Л.Хетагурова\nГабисова Георгия ПМ 11.1",
                "О программе",
                MessageBoxButtons.OK);
        }

        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
