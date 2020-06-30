using System;

namespace DistanceConverter.exe
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceConverter = new DistanceConverter();
            for (int feet = 1; feet <= 10; feet++)
            {
                System.Console.WriteLine("{0} ft = {1: 0.0000} m", feet, distanceConverter.FeetToMeter(feet));
            }
        }
    }
}
