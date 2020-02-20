using System;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] integer = text.Split();
            int[] numbers = new int[integer.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(integer[i]);
            }
            int sum = 0;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber % 2 == 0)
                {
                    sum += currentNumber;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
