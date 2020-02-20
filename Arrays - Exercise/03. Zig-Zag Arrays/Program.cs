using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] zig = new int[n];
            int[] zag = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] zigZag = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 != 0)
                {
                    zig[i - 1] = zigZag[0];
                    zag[i - 1] = zigZag[1];
                }
                else
                {
                    zig[i - 1] = zigZag[1];
                    zag[i - 1] = zigZag[0];
                }

            }
            Console.WriteLine(string.Join(" ", zig));
            Console.WriteLine(string.Join(" ", zag));

        }
    }
}
