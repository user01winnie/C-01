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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int com = 0;
        int pla = 0;

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Text = "剪刀石頭布";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "剪刀";
            Random r = new Random();
            int n = r.Next(1, 4);
            if (n == 1)
            {
                label1.Text = "剪刀";
                toolStripStatusLabel1.Text = com + ":" + pla;
            }
            else if (n == 2)
            {
                label1.Text = "石頭";
                com++;
                toolStripStatusLabel1.Text = com + ":" + pla;
            }
            else
            {
                label1.Text = "布";
                pla++;
                toolStripStatusLabel1.Text = com + ":" + pla;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "石頭";
            Random r = new Random();
            int n = r.Next(1, 4);
            if (n == 1)
            { 
                label1.Text = "剪刀";
                pla++;
                toolStripStatusLabel1.Text = com + ":" + pla;
            }
            else if (n == 2)
            {
                label1.Text = "石頭";
                toolStripStatusLabel1.Text = com + ":" + pla;
            }
            else
            {
                label1.Text = "布";
                com++;
                toolStripStatusLabel1.Text = com + ":" + pla;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "布";
            Random r = new Random();
            int n = r.Next(1, 4);
            if (n == 1)
            {
                label1.Text = "剪刀";
                com++;
                toolStripStatusLabel1.Text=com + ":" + pla;
            }
            else if (n == 2)
            {
                label1.Text = "石頭";
                pla++;
                toolStripStatusLabel1.Text = com + ":" + pla;
            }
            else
            {
                label1.Text = "布";
                toolStripStatusLabel1.Text = com + ":" + pla;
            }
        }
    }
}
