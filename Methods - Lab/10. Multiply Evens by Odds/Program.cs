using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(Math.Abs(input)));

        }
        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                int b = n % 10;
                n = n / 10;
                if (b % 2 != 0)
                {
                    sum += b;
                }
            }
            return sum;
        }
        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                int b = n % 10;
                n = n / 10;
                if (b % 2 == 0)
                {
                    sum += b;
                }
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int n)
        {
            return GetSumOfEvenDigits(n) * GetSumOfOddDigits(n);
        }
    }
}
