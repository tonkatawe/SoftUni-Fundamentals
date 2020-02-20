using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestOfNumber(a, b, c));
        }
        static int SmallestOfNumber(int a, int b, int c)
        {
            int smallestNum = int.MaxValue;
            if (a < smallestNum)
            {
                smallestNum = a;
            }
            if (smallestNum > b)
            {
                smallestNum = b;
            }
            if (smallestNum > c)
            {
                smallestNum = c;
            }
            return smallestNum;
        }
    }
}
