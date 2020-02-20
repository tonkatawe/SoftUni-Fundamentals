using System;
using System.Collections.Generic;
namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().TrimStart(new char[] { '0' });
            int number = int.Parse(Console.ReadLine());
            int currentNum = 0;
            int firstPart = 0;
            int secondPart = 0;
            if (number == 0)
            {
                Console.WriteLine(0);
                return;
            }
            List<int> result = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                string currchar = input[i].ToString();
                currentNum = int.Parse(currchar);
                currentNum *= number;
                currentNum += secondPart;
                firstPart = currentNum % 10;
                secondPart = currentNum / 10;

                result.Add(firstPart);
            }
            if (secondPart > 0)
            {
                result.Add(secondPart);
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));

        }
    }
}
