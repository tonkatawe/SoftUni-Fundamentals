using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SignOfIntegerNumbers(int.Parse(Console.ReadLine()));
        }
        static void SignOfIntegerNumbers(int input)
        {
            if (input > 0)
            {
                Console.WriteLine($"The number {input} is positive.");
            }
            if (input < 0)
            {
                Console.WriteLine($"The number {input} is negative.");
            }
            if (input == 0)
            {
                Console.WriteLine($"The number {input} is zero.");
            }
        }
    }
}
