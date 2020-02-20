using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int k = i + 1; k <= arr.Length - 1; k++)
                {
                    if ((arr[i] + arr[k]) == num)
                    {
                        Console.WriteLine($"{arr[i]} {arr[k]}");
                    }
                }

            }
        }
    }
}
