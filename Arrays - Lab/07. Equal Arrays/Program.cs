using System;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string textOne = Console.ReadLine();
            string textTwo = Console.ReadLine();
            string[] arrStringOne = textOne.Split();
            string[] arrStringTwo = textTwo.Split();
            int[] rowOne = new int[arrStringOne.Length];
            int[] rowTwo = new int[arrStringTwo.Length];
            int sum = 0;
            for (int i = 0; i < arrStringOne.Length; i++)
            {
                rowOne[i] = int.Parse(arrStringOne[i]);
                rowTwo[i] = int.Parse(arrStringTwo[i]);
                if (rowTwo[i] == rowTwo[i])
                {
                    sum += rowTwo[i];
                }
                if (rowTwo[i] != rowOne[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");

        }
    }
}
