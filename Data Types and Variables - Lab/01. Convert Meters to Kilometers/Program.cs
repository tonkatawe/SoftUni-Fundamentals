using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int metters = int.Parse(Console.ReadLine());
            decimal kilometers = metters / 1000m;
            Console.WriteLine($"{kilometers:F2}");

        }
    }
}
