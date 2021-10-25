using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked && radioButton7.Checked && radioButton10.Checked)
            {
                MessageBox.Show("100分");
            }
            else if (radioButton3.Checked && radioButton7.Checked) { MessageBox.Show("60分"); }
            else if (radioButton7.Checked && radioButton10.Checked) { MessageBox.Show("60分"); }
            else if (radioButton3.Checked && radioButton10.Checked) { MessageBox.Show("60分"); }
            else if (radioButton3.Checked || radioButton7.Checked || radioButton10.Checked)
            {
                if (radioButton3.Checked) { MessageBox.Show("30分"); }
                else if (radioButton7.Checked) { MessageBox.Show("30分"); }
                else if (radioButton10.Checked) { MessageBox.Show("30分"); }
            }
            else if(radioButton1.Checked && radioButton9.Checked && radioButton11.Checked)
            {
                MessageBox.Show("0分");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
