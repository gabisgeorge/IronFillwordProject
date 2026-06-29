using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronFillword
{
    internal class GameUIHelper
    {
        private DataGridView dataGridView;

        public GameUIHelper(DataGridView gridView)
        {
            dataGridView = gridView;
        }

        public void InitializeGrid(int fieldSize)
        {
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
            dataGridView.MultiSelect = false;

            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            for (int i = 0; i < fieldSize; i++)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    Name = "Col" + i,
                    HeaderText = i.ToString(),
                    Tag = i.ToString(),
                    Width = 50
                };
                dataGridView.Columns.Add(column);
                dataGridView.Rows.Add(new DataGridViewRow { Height = 50 });
            }
        }

        public void FillRandomLetters(int fieldSize)
        {
            Random random = new Random();
            string alphabet = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭÆЯЧСМИТЬБЮ";

            for (int col = 0; col < fieldSize; col++)
            {
                for (int row = 0; row < fieldSize; row++)
                {
                    if (dataGridView[col, row].Value == null)
                    {
                        dataGridView[col, row].Value = alphabet[random.Next(alphabet.Length)].ToString();
                    }
                }
            }
        }

        public void SetCellGray(int col, int row)
        {
            if (dataGridView[col, row].Style.BackColor != Color.Green)
            {
                dataGridView[col, row].Style.BackColor = Color.Gray;
            }
        }

        public void SetupFormSize(Form form, int fieldSize, TextBox textBoxWordsList, Button buttonCheckWord)
        {
            if (fieldSize == 8)
            {
                dataGridView.Size = new Size(400, 403);
                dataGridView.Location = new Point(19, 92);
                form.Size = new Size(950, 545);
                textBoxWordsList.Location = new Point(3, 22);
                textBoxWordsList.Size = new Size(345, 480);
                buttonCheckWord.Location = new Point(434, 372);
                buttonCheckWord.Size = new Size(121, 123);
            }
            else
            {
                dataGridView.Size = new Size(532, 604);
                dataGridView.Location = new Point(19, 92);
                form.Size = new Size(1051, 747);
                textBoxWordsList.Location = new Point(3, 22);
                textBoxWordsList.Size = new Size(345, 683);
                buttonCheckWord.Location = new Point(557, 573);
                buttonCheckWord.Size = new Size(121, 123);
            }
        }
    }
}
