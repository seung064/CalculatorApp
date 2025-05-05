using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

        public TempConverter(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            int result;
            result = op.parseEquation(textBox_result.Text);
            textBox_input.Text = result.ToString();
        }

        // ⌫ button 클릭시 동작하는 함수 / 마지막 index삭제
        private void button_delete_Click(object sender, EventArgs e)
        {
            int idx_input = textBox_input.Text.Length;
            if (idx_input > 0)
            {
                textBox_input.Text = textBox_result.Text.Remove(idx_input - 1, 1);
            }
        }

        // CE button 클릭시 동작하는 함수 / 현재작성 중인 식 삭제
        private void button_ClearEntry_Click(object sender, EventArgs e)
        {
            textBox_input.Text = op.ClearEntry(textBox_result.Text);
        }

        // 양수, 음수 변환 button 클릭시 동작하는 함수 / 양수, 음수 변환
        private void button_ToggleSign_Click(object sender, EventArgs e)
        {
            textBox_input.Text = op.ToggleSign(int.Parse(textBox_result.Text)).ToString();
        }

        private System.Windows.Forms.Button button_Result;
    }
}

public class TempConverter : UserControl
{


    // 열거형
    public enum TemperatureUnit
    {
        Celsius,
        Fahrenheit,
        Kelvin
    }
    TemperatureUnit unit = TemperatureUnit.Celsius;
    /*
    public double Convert(double valve, TemperatureUnit from, TemperatureUnit to)
    {
        double result = 0;

        switch (from)
        {
            case TemperatureUnit.Celsius: // 
                from = TemperatureUnit.Celsius;
                to = TemperatureUnit.Celsius;
                break;

            case TemperatureUnit.Fahrenheit:
                from 
        }


    }
    */

    

}