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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        int c = 1;
        int r;
        private void Form8_Load(object sender, EventArgs e)
        {
            this.Text = "Tic-tac-toe (雙人遊戲)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = c + 1;  //當按下按鈕後，C便會依續增加

            r = c % 2;

            if (r == 0)  //第一個按下時C=1+1,r=0,則按鈕印出是"O"
            { button1.Text = "O"; }

            else if (r == 1)  //第二個按下時C=2+1,r=1,則按鈕印出是"X"
            { button1.Text = "X"; }

            //textBox1.Text = r.ToString(); //將餘數印出來
            button1.Enabled = false;      //按一次button1後，此按鈕會變不會在執行了
            check();  //此為函式,將會重複輸入的程式碼,統一打在此函式裡
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c = c + 1;
            r = c % 2;

            if (r == 0)
            { button2.Text = "O"; }

            else if (r == 1)
            { button2.Text = "X"; }
            button2.Enabled = false;
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c = c + 1;
            r = c % 2;

            if (r == 0)
            { button3.Text = "O"; }

            else if (r == 1)
            { button3.Text = "X"; }
            button3.Enabled = false;
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c = c + 1;
            r = c % 2;

            if (r == 0)
            { button4.Text = "O"; }

            else if (r == 1)
            { button4.Text = "X"; }
            button4.Enabled = false;
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            c = c + 1;
            r = c % 2;

            if (r == 0)
            { button5.Text = "O"; }

            else if (r == 1)
            { button5.Text = "X"; }
            button5.Enabled = false;
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            c = c + 1;
            r = c % 2;

            if (r == 0)
            { button6.Text = "O"; }

            else if (r == 1)
            { button6.Text = "X"; }
            button6.Enabled = false;
            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            c = c + 1;
            r = c % 2;

            if (r == 0)
            { button7.Text = "O"; }

            else if (r == 1)
            { button7.Text = "X"; }
            button7.Enabled = false;
            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            c = c + 1;
            r = c % 2;
            if (r == 0)
            { button8.Text = "O"; }

            else if (r == 1)
            { button8.Text = "X"; }
            button8.Enabled = false;
            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            c = c + 1;
            r = c % 2;

            if (r == 0)
            { button9.Text = "O"; }

            else if (r == 1)
            { button9.Text = "X"; }
            button9.Enabled = false;
            check();
        }
        private void check()
        {

            if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            || (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            || (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            {
                MessageBox.Show("O 贏囉^^");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
            else if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            || (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            || (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
            {
                MessageBox.Show("X 贏囉^^");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            //如果全部按鈕按完後沒人贏,則跳出平手

            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false &&
            button4.Enabled == false && button5.Enabled == false && button6.Enabled == false &&
            button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("平手哦");
            }
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            button1.Text = " "; button2.Text = " "; button3.Text = " ";
            button4.Text = " "; button5.Text = " "; button6.Text = " ";
            button7.Text = " "; button8.Text = " "; button9.Text = " ";

            button1.Enabled = true; button2.Enabled = true; button3.Enabled = true;
            button4.Enabled = true; button5.Enabled = true; button6.Enabled = true;
            button7.Enabled = true; button8.Enabled = true; button9.Enabled = true;
        }
    }
}
