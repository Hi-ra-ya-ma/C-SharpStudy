using System.Linq;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceConverter = new DistanceConverter();
            var maxNum = 10;
            var converterFlg = args.Length >= 1 && args[0] == "-tom";
            foreach (var i in Enumerable.Range(1, maxNum))
            {
                System.Console.WriteLine
                (
                    "{0} ft = {1: 0.0000} m",
                    i,
                    converterFlg ? distanceConverter.FeetToMeter(i) : distanceConverter.MeterToFeet(i)
                );
            }
        }
    }
}
