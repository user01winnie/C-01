using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        object x;
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (object item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("$3000 任意門");
            listBox1.Items.Add("$3000 桃太郎丸子");
            listBox1.Items.Add("$3000 翻譯蒟蒻");
            listBox1.Items.Add("$3000 穿透環");
            listBox1.Items.Add("$3000 縮小燈");
            listBox1.Items.Add("$3000 記憶麵包");
            listBox1.Items.Add("$3000 時光機");
            listBox1.Items.Add("$3000 竹蜻蜓");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否刪除該道具", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FileInfo f = new FileInfo(listBox2.SelectedItem.ToString());
                listBox2.Items.Remove(listBox2.SelectedItem);
                f.Delete();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            for(int i = 0; i < listBox2.Items.Count; i++)
            {
                str += listBox2.Items[i].ToString();
            }
            MessageBox.Show("你購買了"+str+"\n");
        }
    }
}
