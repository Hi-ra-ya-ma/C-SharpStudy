using System;
namespace DistanceConverter
{
    public class DistanceConverter
    {
        private const double ratio = 0.3048;
        public double FeetToMeter(int feet)
        {
            return feet * ratio;
        }

        public double MeterToFeet(int meter)
        {
            return meter / ratio;
        }
    }
}
