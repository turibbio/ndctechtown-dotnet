using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(args[0]);
            int b = int.Parse(args[2]);
            string operand = args[1];
            float answer;

            switch (operand)
            {
                case "+":
                    answer = new Calculator().Sum(a, b);
                    break;
                case "-":
                    answer = new Calculator().Sub(a, b);
                    break;
                case "*":
                    answer = new Calculator().Multiply(a, b);
                    break;
                case "/":
                    answer = new Calculator().Divide(a, b);
                    break;
                default:
                    answer = 0;
                    break;
            }
 
            Console.WriteLine(a.ToString() + " " + operand + " " + b.ToString() + " = " + answer.ToString());
        }
    }
}
