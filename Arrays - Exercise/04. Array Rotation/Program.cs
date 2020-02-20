using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int temporary = arr[0];
                for (int k = 0; k < arr.Length - 1; k++)
                {
                    arr[k] = arr[k + 1];
                }
                arr[arr.Length - 1] = temporary;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
