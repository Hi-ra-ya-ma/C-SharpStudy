
namespace DistanceConverter
{
    class DistanceConverter
    {
        public double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }

        public double MeterToFeet(int meter)
        {
            return meter / 0.3048;
        }
    }
}