namespace IronFillword
{
    partial class FormGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCheckWord = new System.Windows.Forms.Button();
            this.labelGuessedWords = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.dataGridViewGameField = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.словарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxWords = new System.Windows.Forms.GroupBox();
            this.textBoxWordsList = new System.Windows.Forms.TextBox();
            this.timerGuessedWords = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGameField)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCheckWord);
            this.panel1.Controls.Add(this.labelGuessedWords);
            this.panel1.Controls.Add(this.labelTimer);
            this.panel1.Controls.Add(this.dataGridViewGameField);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 505);
            this.panel1.TabIndex = 0;
            // 
            // buttonCheckWord
            // 
            this.buttonCheckWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckWord.Location = new System.Drawing.Point(434, 372);
            this.buttonCheckWord.Name = "buttonCheckWord";
            this.buttonCheckWord.Size = new System.Drawing.Size(121, 123);
            this.buttonCheckWord.TabIndex = 4;
            this.buttonCheckWord.Text = "Афæлварын дзырд";
            this.buttonCheckWord.UseVisualStyleBackColor = true;
            this.buttonCheckWord.Click += new System.EventHandler(this.buttonCheckWord_Click);
            // 
            // labelGuessedWords
            // 
            this.labelGuessedWords.AutoSize = true;
            this.labelGuessedWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuessedWords.Location = new System.Drawing.Point(15, 69);
            this.labelGuessedWords.Name = "labelGuessedWords";
            this.labelGuessedWords.Size = new System.Drawing.Size(101, 20);
            this.labelGuessedWords.TabIndex = 3;
            this.labelGuessedWords.Text = "Ссардтай: 0";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.Location = new System.Drawing.Point(15, 44);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(90, 20);
            this.labelTimer.TabIndex = 2;
            this.labelTimer.Text = "Рæстæг: 0";
            this.labelTimer.Click += new System.EventHandler(this.labelTimer_Click);
            // 
            // dataGridViewGameField
            // 
            this.dataGridViewGameField.AllowUserToAddRows = false;
            this.dataGridViewGameField.AllowUserToDeleteRows = false;
            this.dataGridViewGameField.AllowUserToResizeColumns = false;
            this.dataGridViewGameField.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewGameField.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewGameField.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGameField.ColumnHeadersVisible = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGameField.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewGameField.EnableHeadersVisualStyles = false;
            this.dataGridViewGameField.Location = new System.Drawing.Point(19, 92);
            this.dataGridViewGameField.MultiSelect = false;
            this.dataGridViewGameField.Name = "dataGridViewGameField";
            this.dataGridViewGameField.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGameField.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewGameField.RowHeadersVisible = false;
            this.dataGridViewGameField.ShowCellToolTips = false;
            this.dataGridViewGameField.ShowEditingIcon = false;
            this.dataGridViewGameField.Size = new System.Drawing.Size(400, 403);
            this.dataGridViewGameField.TabIndex = 1;
            this.dataGridViewGameField.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGameField_CellClick);
            this.dataGridViewGameField.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGameField_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameToolStripMenuItem,
            this.словарьToolStripMenuItem,
            this.правилаИгрыToolStripMenuItem,
            this.результатыToolStripMenuItem1});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.играToolStripMenuItem.Text = "Хъазт";
            // 
            // NewGameToolStripMenuItem
            // 
            this.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            this.NewGameToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.NewGameToolStripMenuItem.Text = "Ног хъазт";
            this.NewGameToolStripMenuItem.Click += new System.EventHandler(this.результатыToolStripMenuItem_Click);
            // 
            // словарьToolStripMenuItem
            // 
            this.словарьToolStripMenuItem.Name = "словарьToolStripMenuItem";
            this.словарьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.словарьToolStripMenuItem.Text = "Дзырдуат";
            this.словарьToolStripMenuItem.Click += new System.EventHandler(this.словарьToolStripMenuItem_Click);
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.правилаИгрыToolStripMenuItem.Text = "Хъазты правилæтæ";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // результатыToolStripMenuItem1
            // 
            this.результатыToolStripMenuItem1.Name = "результатыToolStripMenuItem1";
            this.результатыToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.результатыToolStripMenuItem1.Text = "Результаттæ";
            this.результатыToolStripMenuItem1.Click += new System.EventHandler(this.результатыToolStripMenuItem1_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxWords);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(582, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 505);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxWords
            // 
            this.groupBoxWords.Controls.Add(this.textBoxWordsList);
            this.groupBoxWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxWords.Location = new System.Drawing.Point(0, 0);
            this.groupBoxWords.Name = "groupBoxWords";
            this.groupBoxWords.Size = new System.Drawing.Size(351, 505);
            this.groupBoxWords.TabIndex = 0;
            this.groupBoxWords.TabStop = false;
            this.groupBoxWords.Text = "Дзырдтæ";
            // 
            // textBoxWordsList
            // 
            this.textBoxWordsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWordsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWordsList.Location = new System.Drawing.Point(3, 22);
            this.textBoxWordsList.Multiline = true;
            this.textBoxWordsList.Name = "textBoxWordsList";
            this.textBoxWordsList.ReadOnly = true;
            this.textBoxWordsList.Size = new System.Drawing.Size(345, 480);
            this.textBoxWordsList.TabIndex = 0;
            // 
            // timerGuessedWords
            // 
            this.timerGuessedWords.Tick += new System.EventHandler(this.timerGuessedWords_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGame";
            this.Text = "Iron Fillword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGameField)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxWords.ResumeLayout(false);
            this.groupBoxWords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxWords;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem словарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewGameField;
        private System.Windows.Forms.Label labelGuessedWords;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.TextBox textBoxWordsList;
        private System.Windows.Forms.Button buttonCheckWord;
        private System.Windows.Forms.Timer timerGuessedWords;
    }
}

