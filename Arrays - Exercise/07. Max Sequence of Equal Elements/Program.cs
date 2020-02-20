using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int currentNum = 0;
            int counter = 0;
            int bestCount = 0;
            int bestnum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                currentNum = arr[i];
                if (currentNum == arr[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }
                if (counter > bestCount)
                {
                    bestCount = counter;
                    bestnum = arr[i];

                }

            }
            for (int i = 0; i <= bestCount; i++)
            {
                Console.Write(bestnum + " ");
            }
        }
    }
}
