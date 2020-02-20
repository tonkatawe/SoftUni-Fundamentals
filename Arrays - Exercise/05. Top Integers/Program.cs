using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                bool check = true;
                for (int k = i + 1; k < arr.Length; k++)
                {

                    if (arr[i] <= arr[k])
                    {
                        check = false;
                    }
                }
                if (check)
                {

                    Console.Write(arr[i] + " ");
                }

            }

        }
    }
}
