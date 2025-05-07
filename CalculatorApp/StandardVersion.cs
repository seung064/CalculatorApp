using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class StandardVersion : UserControl
    {
        Operation op = new Operation();
        private bool isCalculated = false;

        public StandardVersion()
        {
            InitializeComponent();
        }

        //숫자 button이랑 +, -, *, ÷, % 클릭 시 동작하는 함수입니다!
        
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            textBox_result.Text += ((Button)sender).Text; //숫자일 경우 여기로 바로 점프!
        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
            char[] ch = { '+', '-', '*', '÷', '%' };
            int idx = textBox_result.Text.Length;
            
            //아래 if문은 예외 처리를 위한 영역임.
            //예외 경우#1 : 아무 숫자도 입력되지 않은 채로 연산자가 클릭됐을 경우 if문 PASS
            //예외 경우#2 : 이미 len이 1 이상(숫자가 하나라도 입력돼있는 상태에서, 이미 들어가있는 연산자가 있다면 새로 누른 연산자로 체인지!
            if (idx != 0 && ch.Contains(textBox_result.Text[idx - 1]))
            {
                char[] chars = textBox_result.Text.ToCharArray(); //입력된 수식을 char로 다 쪼개서 array에 넣기. 그 이유는 index를 자유자재로 다루기 위함. (<=> string은 index 접근 불가하다)
                chars[idx - 1] = ((Button)sender).Text[0]; //마지막 index 값에 금방 클릭한 버튼의 값을 바꿔 넣어준다.
                textBox_result.Text = new string(chars); //textBox.Text에 값을 넣어준다.
            }

            //int tmp;
            //string doubleOpCheck = op.parseEquation(textBox_result.Text);
            //if (int.TryParse(doubleOpCheck, out tmp) == false)
            //{
            //    textBox_result.Text = doubleOpCheck;
            //}
        }


        // = button 클릭 시 동작하는 함수입니다! 연산을 수행하도록 하는 함수예요!
        private void button_Result_Click(object sender, EventArgs e)
        {
            string result;
            result = op.parseEquation(textBox_result.Text);
            textBox_result.Text = result;
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
            textBox_result.Text = op.ClearEntry(textBox_result.Text);
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
    }
}
