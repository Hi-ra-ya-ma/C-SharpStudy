using System;
using System.Linq;

namespace agc083_c
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            long x = inputLongArray[0];
            long y = inputLongArray[1];
            long cnt = 0;
            while (x <= y)
            {
                x *= 2;
                cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}
