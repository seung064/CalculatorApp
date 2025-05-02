using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        Operation op = new Operation();
        public Form1()
        {
            InitializeComponent();
        }


        //숫자 button이랑 +, -, *, ÷, % 클릭 시 동작하는 함수입니다!
        private void button_Click(object sender, EventArgs e)
        {
            char[] op = {'+', '-', '*', '÷', '%'};
            int idx = textBox1.Text.Length;
            if (idx != 0 && op.Contains(textBox1.Text[idx - 1]) && op.Contains(((Button)sender).Text[0]))
            {
                Console.WriteLine(idx + " TEST : " + textBox1.Text[idx - 1] + " || " + op.Contains(textBox1.Text[idx - 1]) + "\r\n");
                char[] chars = textBox1.Text.ToCharArray();
                chars[idx - 1] = ((Button)sender).Text[0];
                textBox1.Text = new string(chars);
                return;
            }
            textBox1.Text += ((Button)sender).Text;
        }


        // = button 클릭 시 동작하는 함수입니다! 연산을 수행하도록 하는 함수예요!
        private void button_Result_Click(object sender, EventArgs e)
        {
            int result;
            result = op.parseEquation(textBox1.Text);
            textBox1.Text = result.ToString();
        }
        
    }
}
