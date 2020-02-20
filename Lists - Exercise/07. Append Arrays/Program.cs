using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> numbers = input.Split('|').Reverse().ToList();
            List<int> stringToInt = new List<int>();
            foreach (var item in numbers)
            {
                stringToInt.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", stringToInt));


        }
    }
}
