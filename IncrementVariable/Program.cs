using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int incrementTimes = int.Parse(Console.ReadLine());
            int overFlowTimes = 0;

            byte number = 0;

            for (int i = 0; i < incrementTimes; i++)
            {
                number++;

                if (number == 0)
                {
                    overFlowTimes++;
                }
            }

            Console.WriteLine(number);

            if (overFlowTimes > 0)
            {
                Console.WriteLine("Overflowed " + overFlowTimes + " times");
            }
        }
    }
}