using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CalculatorApp
{
    public partial class StandardVersion : UserControl
    {
        Operation op = new Operation();

        public StandardVersion()
        {
            InitializeComponent();
        }

        //숫자 button이랑 +, -, *, ÷, % 클릭 시 동작하는 함수입니다!
        private void button_Click(object sender, EventArgs e)
        {
            char[] op = { '+', '-', '*', '÷', '%' };
            int idx = textBox_result.Text.Length;
            char clickedOperator = ((Button)sender).Text[0];
            string text = textBox_result.Text;

            if (idx != 0 && op.Contains(textBox_result.Text[idx - 1]) && op.Contains(((Button)sender).Text[0]))
            {
                //Console.WriteLine(idx + " TEST : " + textBox_result.Text[idx - 1] + " || " + op.Contains(textBox_result.Text[idx - 1]) + "\r\n");
                char[] chars = textBox_result.Text.ToCharArray();
                chars[idx - 1] = ((Button)sender).Text[0];
                textBox_result.Text = new string(chars);
                return;
            }

            if (op.Contains(clickedOperator) && text.Length > 0 && !op.Contains(text.Last()))
            {
                int lastOpIndex = text.LastIndexOfAny(op);
                if (lastOpIndex >= 0 && lastOpIndex < text.Length - 1) // 연산자가 있고, 그 뒤에 숫자도 있을때만 실행
                {
                    // "숫자 + 연산자 + 숫자" 형태일 경우 계산
                    string left = text.Substring(0, lastOpIndex);  // 연산자 앞의 부분
                    string right = text.Substring(lastOpIndex + 1);  // 연산자 뒤의 부분

                    // 숫자 + 연산자 + 숫자 형태로 나눠서 계산
                    double a = double.Parse(left);
                    double b = double.Parse(right);
                    double result = 0;

                    switch (text[lastOpIndex])  // 마지막 연산자 확인
                    {
                        case '+':
                            result = a + b;
                            break;
                        case '-':
                            result = a - b;
                            break;
                        case '*':
                            result = a * b;
                            break;
                        case '÷':
                            result = b != 0 ? a / b : 0; // 0으로 나누기 방지
                            break;
                        case '%':
                            result = a % b;
                            break;
                    }

                    // 계산 후 결과와 새로운 연산자 추가
                    textBox_result.Text = result.ToString() + clickedOperator;
                    return;
                }

            }
            // 연산자 외의 다른 버튼 (숫자 등) 클릭 시 텍스트 추가
            textBox_result.Text += ((Button)sender).Text;
        }
        

        /*
                    if (idx !=0 && op.Contains(textBox_result.Text[idx - 1]) && text.Count(c => op.Contains(c)) >= 2)
                    {
                        // 연산자가 두 개 이상 있는 경우
                        // ex) "12+3+" 형태면 → "12+3"을 계산

                        // 마지막 연산자 제외
                        string expression = text.Substring(0, text.Length - 1);

                        // 정규식으로 숫자 + 연산자 + 숫자 형태 추출

        ;

                        if (match.Success)
                        {
                            double lhs = double.Parse(match.Groups[1].Value);
                            char oper = match.Groups[2].Value[0];
                            double rhs = double.Parse(match.Groups[3].Value);

                            double result = 0;

                            switch (oper)
                            {
                                case '+':
                                    result = lhs + rhs;
                                    break;
                                case '-':
                                    result = lhs - rhs;
                                    break;
                                case '*':
                                    result = lhs * rhs;
                                    break;
                                case '÷':
                                    result = (rhs != 0) ? lhs / rhs : 0;
                                    break;
                                case '%':
                                    result = lhs % rhs;
                                    break;
                            }
                            textBox_result.Text = result.ToString() + clickedOperator;
                            return;
                        }
                    }
                    textBox_result.Text += ((Button)sender).Text;
                }
        */

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
