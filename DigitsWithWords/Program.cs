using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsWithWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string result = string.Empty;
            switch (number)
            {
                case "zero":
                    result = "0";
                    break;
                case "one":
                    result = "1";
                    break;
                case "two":
                    result = "2";
                    break;
                case "three":
                    result = "3";
                    break;
                case "four":
                    result = "4";
                    break;
                case "five":
                    result = "5";
                    break;
                case "six":
                    result = "6";
                    break;
                case "seven":
                    result = "7";
                    break;
                case "eight":
                    result = "8";
                    break;
                case "nine":
                    result = "9";
                    break;
                case "ten":
                    result = "10";
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
