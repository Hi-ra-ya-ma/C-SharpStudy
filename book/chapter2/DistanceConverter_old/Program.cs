using System;

namespace DistanceConverter.exe
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceConverter = new DistanceConverter();
            var maxNum = 10;
            foreach (var i in Enumerable.Range(1, maxNum))
            {
                System.Console.WriteLine
                (
                    "{0} ft = {1: 0.0000} m",
                    i,
                    args[0] == "-tom" ? distanceConverter.FeetToMeter(i) : distanceConverter.MeterToFeet(i)
                );
            }
        }
    }
}
