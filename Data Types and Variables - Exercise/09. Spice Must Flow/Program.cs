using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYield = int.Parse(Console.ReadLine());
            int currentYield = startYield;
            int rest = 0;
            int days = 0;
            int sum = 0;
            while (currentYield >= 100)
            {
                days++;
                rest = currentYield - 26;
                currentYield -= 10;
                sum += rest;

            }
            if (days > 0)
            {
                sum -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(sum);
        }
    }
}
