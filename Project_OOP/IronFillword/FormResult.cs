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
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();

        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            string[] content = File.ReadAllLines("Results.txt");
            foreach (string line in content)
            {
                richTextBoxRes.Text += $"{line} \n";
            }
        }

        private void FormResult_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
