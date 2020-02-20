using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TopNumber(number);
        }
        private static void TopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                bool oddDigit = false;
                int cpy = i;
                while (true)
                {
                    if (cpy == 0)
                    {
                        break;
                    }
                    int right = cpy % 10;
                    sum += right;
                    if (!(right % 2 == 0))
                    {
                        oddDigit = true;
                    }
                    cpy /= 10;
                }
                if (sum % 8 == 0 && oddDigit == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
