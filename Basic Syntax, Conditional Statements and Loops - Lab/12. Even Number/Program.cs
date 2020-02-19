using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int command = int.Parse(Console.ReadLine());
            while (command % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                command = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(command)}");
        }
    }
}
