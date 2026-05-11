namespace IronFillword
{
    partial class FormRichTextBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxWrds = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxWrds
            // 
            this.richTextBoxWrds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxWrds.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxWrds.Name = "richTextBoxWrds";
            this.richTextBoxWrds.ReadOnly = true;
            this.richTextBoxWrds.Size = new System.Drawing.Size(800, 450);
            this.richTextBoxWrds.TabIndex = 0;
            this.richTextBoxWrds.Text = "";
            this.richTextBoxWrds.TextChanged += new System.EventHandler(this.richTextBoxWrds_TextChanged);
            // 
            // FormRichTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxWrds);
            this.Name = "FormRichTextBox";
            this.Text = "Дзырдуат";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxWrds;
    }
}