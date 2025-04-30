using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_if
{
    public partial class Form1 : Form
    {
        string inputData = "";

        public Form1()
        {
            InitializeComponent();

            //string inputData = "";

            //textBox1.Text = "입력: " + inputData + "\r\n";
            //if (Coin(true))
            //{
            //    textBox1.Text += "승리";
            //}
            //else
            //{
            //    textBox1.Text += "패배";
            //}

        }

        bool Coin(bool a)
        {
            Random random = new Random();
            //int n = random.Next(100);   //0~99
            int n = random.Next(1, 100);   //1~99
            textBox2.Text += n + "\r\n";
            int result = n % 2;

            if (result == 0)
            {
                return false;
            }
            else if (result == 1)
            {
                return true;
            }

            return false;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // 실제 처리 내용 (없으면 비워둬도 OK)

            if (inputData.Equals("") && radioButton1.Checked) {
                textBox1.Text = "true";
                textBox2.Text = "";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (inputData.Equals("") && radioButton2.Checked)
            {
                textBox1.Text = "false";
                textBox2.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputData = textBox1.Text;

            if (inputData.Equals("true") || inputData.Equals("false"))
            {
                textBox2.Text = "입력: " + inputData + "\r\n";
                if (Coin(true))
                {
                    textBox2.Text += "승리";
                }
                else
                {
                    textBox2.Text += "패배";
                }
            }
            else
            {
                textBox2.Text = "true, false 중 입력하세요! \r\n";
            }

            inputData = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            inputData = "";
        }
    }
}
