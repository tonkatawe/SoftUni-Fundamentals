using System;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] array = text.Split();
            int[] textAsString = new int[array.Length];
            int currentNumber = 0;
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                textAsString[i] = int.Parse(array[i]);
            }
            for (int i = 0; i < textAsString.Length; i++)
            {
                currentNumber = textAsString[i];
                if (currentNumber % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else
                {
                    sumOdd += currentNumber;
                }
            }
            int result = sumEven - sumOdd;
            Console.WriteLine(result);
        }
    }
}
