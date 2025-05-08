using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Operation
    {

        //입력받은 계산식을 쪼개는 함수예요! 예컨대 65+7이 입력되었다면, 65와 +와 7로 쪼개서 각 변수에 담아뒀습니다!
        public string parseEquation(string equation)
        {
            string pattern = "[+\\-*÷%]";
            string[] splited = Regex.Split(equation, pattern);
            MatchCollection matches = Regex.Matches(equation, pattern);


            //예외 처리
            if(splited.Length <= 1)
            {
                return 0;
            }
            //여기 a, b 값이랑 연산자 넣어뒀습니다! 이 값들 활용해서 계산해주는 함수들 만들어보셔요!
            int a = int.Parse(splited[0]);
            int b = int.Parse(splited[1]);
            char op = matches[0].ToString()[0];

            //Console.WriteLine($"{a} {op} {b}"); //test code. Console 창에서 확인해보세요!


            //아래와 같이 만들어보실 수 있으실 거예요!
            string result = "";
            if (op == '+')
            {
                result = Add(a, b).ToString();
            }
            else if (op == '-')
            {
                result = Minus(a, b).ToString();
            }
            else if (op == '*')
            {
                result = Multiply(a, b).ToString();
            }
            else if (op == '÷')
            {
                result = Divide(a, b).ToString();
            }
            else if (op == '%')
            {
                result = Remainder(a, b).ToString();
            }

            //혹시 한 수식에 연산자가 2개 이상일 경우 앞의 연산자를 먼저 계산 후 뒤에 연산자를 이어붙인 문자열을 반환해주는 코드
            if (matches.Count >= 2)
            {
                Console.WriteLine($"matches[0] : {matches[0]}, \r\nmatches[1] : {matches[1]}");
                return result + matches[1].ToString();
            }

            return result;
        }



        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, in int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Remainder(int a, int b)
        {
            return a % b;
        }

        public double InverseX(double a) // 1/x
        {
            return 1 / a;
        }

        public double Square(double a) // x^2
        {
            return Math.Pow(a, 2);
        }

        public double Sqrt(double a) // √x
        {
            return Math.Sqrt(a);
        }

        public int ToggleSign(int a) // +/-
        {
            if (a == 0)
            {
                return 0;
            }
            else
            {
                return -a;
            }
        }

        public string ClearEntry(string equation)
        {
            string pattern = "[+\\-*÷%]";
            string[] splited = Regex.Split(equation, pattern);

            Console.WriteLine(splited.Length);
            if (splited.Length >= 2)
            {
                return splited[0];
            }
            return "";
        }
    }
}
