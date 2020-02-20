using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            RemoveNegativeNumbers(numbers);
        }
        static void RemoveNegativeNumbers(List<int> numbers)
        {

            numbers.RemoveAll(n => n < 0);
            numbers.Reverse();
            if (numbers.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }


        }
    }
}
