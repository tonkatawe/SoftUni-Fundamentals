using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] items = numbers.Split();
            double[] num = new double[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                num[i] = double.Parse(items[i]);

            }
            int[] roundedNum = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                roundedNum[i] = (int)Math.Round(num[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{num[i]} => {roundedNum[i]}");
            }


        }
    }
}
