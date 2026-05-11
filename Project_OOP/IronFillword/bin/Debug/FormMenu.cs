using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IronFillword
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            
        }
        public int FieldSize
        {
            get
            {
                
                if (radioButton2.Checked)
                {
                        return 12;
                }
                else
                {
                    return 8;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                FormGame formGame = new FormGame(12);
                formGame.Show();
                this.Hide();
            }
            else if(radioButton1.Checked) 
            {
                FormGame formGame = new FormGame(8);
                formGame.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Равзарут сложность", "Ошибка", MessageBoxButtons.OK);
            }

        }
    }
}
