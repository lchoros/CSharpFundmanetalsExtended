using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexaDecimal = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(hexaDecimal, 16));
        }
    }
}
