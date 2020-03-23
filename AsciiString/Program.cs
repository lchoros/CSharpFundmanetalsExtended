using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiString
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < numberOfLines; i++)
            {
                int number = int.Parse(Console.ReadLine());
                result += (char) number;
            }
            Console.WriteLine(result);
        }
    }
}
