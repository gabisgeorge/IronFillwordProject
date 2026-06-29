namespace IronFillword
{
    partial class FormResult
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
            this.richTextBoxRes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxRes
            // 
            this.richTextBoxRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxRes.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxRes.Name = "richTextBoxRes";
            this.richTextBoxRes.ReadOnly = true;
            this.richTextBoxRes.Size = new System.Drawing.Size(800, 450);
            this.richTextBoxRes.TabIndex = 0;
            this.richTextBoxRes.Text = "";
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxRes);
            this.Name = "FormResult";
            this.Text = "Результаты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormResult_FormClosed);
            this.Load += new System.EventHandler(this.FormResult_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxRes;
    }
}