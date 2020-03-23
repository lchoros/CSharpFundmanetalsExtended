using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char operand = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            switch (operand)
            {
                case '+' :
                    result.Append($"{a} + {b} = {a+b}");
                    break;
                case '-':
                    result.Append($"{a} - {b} = {a - b}");
                    break;
                case '*':
                    result.Append($"{a} * {b} = {a * b}");
                    break;
                case '/':
                    result.Append($"{a} / {b} = {a / b}");
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
