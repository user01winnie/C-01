﻿using System;
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
    public partial class Form7 : Form
    {
        private int[] ans = new int[10];//正確答案
        private String[] gnum = new string[10];//猜的答案數字
        private int tmp, r;
        private Random ran = new Random();

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.Text = "1A2B";
            label1.Text = "猜數字遊戲(請輸入四位數)";
            label2.Text = "";
            label3.Text = "目前輸入" + textBox1.TextLength.ToString() + "個字";
            label4.Text = "";
            button1.Text = "確定";
            button2.Text = "看答案";
            button3.Text = "重玩";
            textBox1.MaxLength = 4;
            for (int i = 0; i < 10; i++)
            {
                ans[i] = i;
            }
            for (int i = 0; i < 10; i++)
            {//決定答案
                r = ran.Next(0, 10 - i);
                tmp = ans[r];
                ans[r] = ans[9 - i];
                ans[9 - i] = tmp;
            }
        }
string num;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "目前輸入" + textBox1.TextLength.ToString() + "個字";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
            button1.Enabled = true;
            for (int i = 0; i < 10; i++)
            {
                r = ran.Next(0, 10 - i);
                tmp = ans[r];
                ans[r] = ans[9 - i];
                ans[9 - i] = tmp;
            }
            for (int j = 1; j <= 4; j++)
            { gnum[j] = ""; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            for (int i = 1; i <= 4; i++) { label2.Text += ans[i]; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            if (textBox1.TextLength != 4)
            {
                MessageBox.Show("請輸入4個不一樣數字");
            }
            else
            {
                for (int j = 1; j <= 4; j++)
                {
                    gnum[j] = textBox1.Text.Substring(j - 1, 1);
                    num += gnum[j];
                }
                if ((gnum[1] == gnum[2] || gnum[1] == gnum[3]
                || gnum[1] == gnum[4] || gnum[2] == gnum[3]
                || gnum[2] == gnum[4] || gnum[3] == gnum[4]))
                {
                    MessageBox.Show("請不要輸入一樣的");
                }
                else
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        for (int l = 1; l <= 4; l++)
                        {
                            if (gnum[k] == ans[l].ToString())
                            {
                                if (k == l) { a++; }
                                else if (k != l) { b++; }
                            }
                        }
                    }
                }
                textBox2.Text += num + "--" + a.ToString() + "A" + b.ToString() + "B" + "\r\n";
                num = "";
                label4.Text = "你已經猜了" + (textBox2.Lines.Length - 1) + "次了";
                textBox1.Focus(); textBox1.SelectAll();
            }
            if (a == 4 && b == 0)
            {
                MessageBox.Show("恭喜猜對了!");
                button1.Enabled = false;
            }
            else if (textBox2.Lines.Length == 11)
            {
                MessageBox.Show("Game Over");
                button1.Enabled = false;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && button1.Enabled == true)
            {
                button1_Click(sender, e);
                textBox1.Focus();
                textBox1.SelectAll();
                e.SuppressKeyPress = true; //讓程式不要發出"叮"一聲 } 
            }

        }
    }
}