using System;

namespace agc088_a
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long a = long.Parse(Console.ReadLine());
            Console.WriteLine(n % 500 <= a ? "Yes" : "No");
        }
    }
}
