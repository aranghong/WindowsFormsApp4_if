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
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "입력: true \r\n";
            if (Coin(true))
            {
                textBox1.Text += "승리";
            }
            else
            {
                textBox1.Text += "패배";
            }

        }

        bool Coin(bool a)
        {
            Random random = new Random();
            //int n = random.Next(100);   //0~99
            int n = random.Next(1, 100);   //1~99
            textBox1.Text += n + "\r\n";
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
    }
}
