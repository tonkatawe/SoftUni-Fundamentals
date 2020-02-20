using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sum = 0;
            string itemOne = input[0];
            string itemTwo = input[1];
            int minLength = Math.Min(itemOne.Length, itemTwo.Length);
            int maxLength = Math.Max(itemOne.Length, itemTwo.Length);
            for (int i = 0; i < minLength; i++)
            {
                sum += itemOne[i] * itemTwo[i];
            }
            for (int i = minLength; i < maxLength; i++)
            {
                if (itemTwo.Length < itemOne.Length)
                {
                    sum += itemOne[i];
                }
                if (itemTwo.Length > itemOne.Length)
                {
                    sum += itemTwo[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
