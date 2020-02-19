using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int figure = 0;
            if (num % 2 == 0 || num % 3 == 0 || num % 6 == 0 || num % 7 == 0 || num % 10 == 0)
            {
                if (num % 2 == 0)
                {
                    figure = 2;
                }
                if (num % 3 == 0)
                {
                    figure = 3;
                }
                if (num % 6 == 0)
                {
                    figure = 6;
                }
                if (num % 7 == 0)
                {
                    figure = 7;
                }
                if (num % 10 == 0)
                {
                    figure = 10;
                }
                Console.WriteLine($"The number is divisible by {figure}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
