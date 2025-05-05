using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    //	[°F] = [°C] × 9⁄5 + 32
    //  [K] = [°C] + 273.15
    public class TempConverterLogic
    {
        public double TempConverter_C_F(double a)
        {
            double result = a * 9 / 5 + 32;
            return result; // 섭씨온도 -> 화씨온도
        }

        public double TempConverter_C_K(double a)
        {
            double result = a + 273.15;
            return result; // 섭씨온도 -> 절대온도
        }
        public double TempConverter_F_C(double a)
        {
            double result = (a - 32) * (5/9);
            return result; // 화씨온도 -> 섭씨온도
        }
        public double TempConverter_F_K(double a)
        {
            double result = (a - 32) * (5/9) + 273.15;
            return result; // 화씨온도 -> 절대온도
        }
        public double TempConverter_K_C(double a)
        {
            double result = a - 273.15;
            return result; // 절대온도 -> 섭씨온도
        }
        public double TempConverter_K_F(double a)
        {
            double result = (a - 273.15) * (9/5) + 32;
            return result; // 절대온도 -> 화씨온도
        }
    }
}