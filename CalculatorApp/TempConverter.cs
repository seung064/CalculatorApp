using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class TempConverter : UserControl
    {
        Operation op = new Operation();

        public TempConverter()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {

            textBox_input.Text += ((Button)sender).Text;
        }

        public TempConverter(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        // ⌫ button 클릭시 동작하는 함수 / 마지막 index삭제
        private void button_delete_Click(object sender, EventArgs e)
        {
            int idx_input = textBox_input.Text.Length;
            if (idx_input > 0)
            {
                textBox_input.Text = textBox_input.Text.Remove(idx_input - 1, 1);
            }
        }

        // CE button 클릭시 동작하는 함수 / 현재작성 중인 식 삭제
        private void button_ClearEntry_Click(object sender, EventArgs e)
        {
            textBox_input.Text = op.ClearEntry(textBox_input.Text);
        }

        // 양수, 음수 변환 button 클릭시 동작하는 함수 / 양수, 음수 변환
        private void button_ToggleSign_Click(object sender, EventArgs e)
        {
            textBox_input.Text = op.ToggleSign(int.Parse(textBox_input.Text)).ToString();
        }

        private TempConverterLogic logic = new TempConverterLogic(); // 온도 변환 로직을 처리하는 클래스


        private void button_Result_Click(object sender, EventArgs e)
        {
            // 예외처리 : 입력값이 숫자가 아닐 경우
            if (!double.TryParse(textBox_input.Text, out double input))
            {
                MessageBox.Show("숫자를 정확히 입력하세요.");
                return;
            }

            double result = 0;
            if (radioButton_input_C.Checked && radioButton_result_F.Checked)
            {
                result = logic.TempConverter_C_F(double.Parse(textBox_input.Text));
                textBox_result.Text = result.ToString();
                return;
            }

            else if (radioButton_input_C.Checked && radioButton_result_K.Checked)
            {
                result = logic.TempConverter_C_K(input);
                textBox_result.Text = result.ToString();
                return;
            }

            else if (radioButton_input_F.Checked && radioButton_result_C.Checked)
            {
                result = logic.TempConverter_F_C(input);
                textBox_result.Text = result.ToString();
                return;
            }
            else if (radioButton_input_F.Checked && radioButton_result_K.Checked)
            {
                result = logic.TempConverter_F_K(input);
                textBox_result.Text = result.ToString();
                return;
            }
            else if (radioButton_input_K.Checked && radioButton_result_C.Checked)
            {
                result = logic.TempConverter_K_C(input);
                textBox_result.Text = result.ToString();
                return;
            }
            else if (radioButton_input_K.Checked && radioButton_result_F.Checked)
            {
                result = logic.TempConverter_K_F(input);
                textBox_result.Text = result.ToString();
                return;
            }
            // 예외처리 C&C, F&F, K&K
            else
            {
                result = input;
                textBox_result.Text = result.ToString();
            }
        }

        // . button 클릭시 동작하는 함수 / 소수점
        private void button_dot_Click(object sender, EventArgs e)
        {
            textBox_input.Text += ".";
        }
    }
}