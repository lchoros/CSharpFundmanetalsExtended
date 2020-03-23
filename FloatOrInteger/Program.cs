using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatOrInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            var isInteger = int.TryParse(number, out int intResult);


            if (isInteger)
            {
                Console.WriteLine(intResult);
            }
            else
            {
                Console.WriteLine(Math.Round(double.Parse(number)));
            }
        }
    }
}
