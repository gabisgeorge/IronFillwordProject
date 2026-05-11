using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronFillword
{
    public partial class FormRichTextBox : Form
    {
        
            
        
        public FormRichTextBox()
        {
            InitializeComponent();
            string[] content = File.ReadAllLines("OsetWordsTranslate.txt");
            foreach (string line in content)
            {
                richTextBoxWrds.Text += $"{line} \n";
            }
        }

        private void richTextBoxWrds_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
