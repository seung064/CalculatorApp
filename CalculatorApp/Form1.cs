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
            panelMain.Visible = false;
        }


        //숫자 button이랑 +, -, *, ÷, % 클릭 시 동작하는 함수입니다!
        private void button_Click(object sender, EventArgs e)
        {
            char[] op = { '+', '-', '*', '÷', '%' };
            int idx = textBox_result.Text.Length;
            if (idx != 0 && op.Contains(textBox_result.Text[idx - 1]) && op.Contains(((Button)sender).Text[0]))
            {
                Console.WriteLine(idx + " TEST : " + textBox_result.Text[idx - 1] + " || " + op.Contains(textBox_result.Text[idx - 1]) + "\r\n");
                char[] chars = textBox_result.Text.ToCharArray();
                chars[idx - 1] = ((Button)sender).Text[0];
                textBox_result.Text = new string(chars);
                return;
            }
            textBox_result.Text += ((Button)sender).Text;
        }


        // = button 클릭 시 동작하는 함수입니다! 연산을 수행하도록 하는 함수예요!
        private void button_Result_Click(object sender, EventArgs e)
        {
            int result;
            result = op.parseEquation(textBox_result.Text);
            textBox_result.Text = result.ToString();
        }

        // ⌫ button 클릭시 동작하는 함수 / 마지막 index삭제
        private void button_delete_Click(object sender, EventArgs e)
        {
            int idx = textBox_result.Text.Length;
            if (idx > 0)
            {
                textBox_result.Text = textBox_result.Text.Remove(idx - 1, 1);
            }
        }

        // C button 클릭시 동작하는 함수 / 전체삭제
        private void button_ClearAll_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "";
        }

        // CE button 클릭시 동작하는 함수 / 현재작성 중인 식 삭제
        private void button_ClearEntry_Click(object sender, EventArgs e)
        {
            //해결못함
        }

        // 1/x button 클릭시 동작하는 함수 / 1/x 계산
        private void button_InverseX_Click(object sender, EventArgs e)
        {
            textBox_result.Text = op.InverseX(double.Parse(textBox_result.Text)).ToString();
        }

        // 제곱근 button 클릭시 동작하는 함수 / 제곱근 계산
        private void button_Square_Click(object sender, EventArgs e)
        {
            textBox_result.Text = op.Square(double.Parse(textBox_result.Text)).ToString();
        }

        // 루트x button 클릭시 동작하는 함수 / 루트x 계산
        private void button_Sqrt_Click(object sender, EventArgs e)
        {
            textBox_result.Text = op.Sqrt(double.Parse(textBox_result.Text)).ToString();
        }

        // 양수, 음수 변환 button 클릭시 동작하는 함수 / 양수, 음수 변환
        private void button_ToggleSign_Click(object sender, EventArgs e)
        {
            textBox_result.Text = op.ToggleSign(int.Parse(textBox_result.Text)).ToString();
        }

        // panelMain 함수
        private void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear(); // 기존 userControl 제거
            //panelMain.Visible = false; // panelMain false
            uc.Dock = DockStyle.Fill; // uc(객체)가 패널을 가득 채움
            panelMain.Controls.Add(uc); // 패널에 usercontrol 추가
        }

        // button_mode 클릭시 동작하는 함수 / panel 변환
        private int form1 = 1;
        private void button_mode_Click(object sender, EventArgs e)
        {
            if (form1 == 1)
            {
                panelMain.Visible = true;
                LoadUserControl(new ScientificCalculatorControl());
                form1 = 2;
            }
            else if(form1 == 2) 
            {
                panelMain.Visible = false;
                form1 = 1;
            }
        }
    }
}