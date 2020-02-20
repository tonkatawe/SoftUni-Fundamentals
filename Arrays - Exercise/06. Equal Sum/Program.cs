using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                for (int k = 0; k < i; k++)
                {
                    sumLeft += input[k];
                }
                for (int j = i + 1; j < input.Length; j++)
                {
                    sumRight += input[j];
                }
                if (sumRight == sumLeft)
                {
                    Console.WriteLine($"{i}");
                    if (input[i] == 0 && input[i + 1] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        return;
                    }
                }

            }
            Console.WriteLine("no");

        }
    }
}
