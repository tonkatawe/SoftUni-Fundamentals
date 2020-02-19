using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {


                Console.WriteLine($"{2 * i - 1}");
                sum += 2 * i - 1;

            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
