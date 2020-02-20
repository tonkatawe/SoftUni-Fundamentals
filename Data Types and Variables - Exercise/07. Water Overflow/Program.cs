using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            short litters = 0;
            short sum = 0;
            for (int i = 0; i < n; i++)
            {
                litters = short.Parse(Console.ReadLine());
                if (sum + litters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                sum += litters;
            }
            Console.WriteLine(sum);
        }
    }
}
