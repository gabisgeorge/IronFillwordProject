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
            ResultManager resultManager = new ResultManager();
            string[] content = resultManager.LoadResults();
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
