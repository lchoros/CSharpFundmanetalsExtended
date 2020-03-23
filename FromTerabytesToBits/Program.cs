using System;

namespace FromTerabytesToBits
{
    class Program
    {
        static void Main(string[] args)
        {
            double terabytes = double.Parse(Console.ReadLine());
            var result = terabytes * 8796093022208;
            Console.WriteLine("{0}", result);
        }
    }
}
