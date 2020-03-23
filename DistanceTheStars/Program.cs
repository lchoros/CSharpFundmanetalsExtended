using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceTheStars
{
    class Program
    {
        static void Main(string[] args)
        {
            string earthToStars = ConvertLightYearsToKilometers(4.22M);
            string centerOfGalaxy = ConvertLightYearsToKilometers(26000M);
            string milkyWay = ConvertLightYearsToKilometers(100000M);
            string earthToObservableUniverse = ConvertLightYearsToKilometers(46500000000M);

            Console.WriteLine(earthToStars);
            Console.WriteLine(centerOfGalaxy);
            Console.WriteLine(milkyWay);
            Console.WriteLine(earthToObservableUniverse);
        }

        public static string ConvertLightYearsToKilometers(decimal lightYear)
        {
            var result = lightYear * 9450000000000;
            return result.ToString("e2", CultureInfo.InvariantCulture);
        }
    }
}
