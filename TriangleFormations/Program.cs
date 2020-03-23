using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleFormations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            bool isAAndB = a * a + b * b == c * c;
            bool isBAndC = b * b + c * c == a * a;
            bool isCAndA = c * c + a * a == b * b;
            bool isValidTriangle = a + b > c && a + c > b && b + c > a;
            if (isValidTriangle)
            {
                Console.WriteLine("Triangle is valid.");
                if (isAAndB)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (isBAndC)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");

                }
                else if (isCAndA)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
