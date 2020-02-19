using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int largest = Math.Max(Math.Max(n1, n2), n3);
            if (largest == n3)
            {
                Console.WriteLine(n3);
                Console.WriteLine(Math.Max(n1, n2));
                Console.WriteLine(Math.Min(n1, n2));
            }
            else if (largest == n2)
            {
                Console.WriteLine(n2);
                Console.WriteLine(Math.Max(n1, n3));
                Console.WriteLine(Math.Min(n1, n3));
            }
            else
            {
                Console.WriteLine(n1);
                Console.WriteLine(Math.Max(n2, n3));
                Console.WriteLine(Math.Min(n2, n3));
            }
        }
    }
}
