using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> middleResult = new List<int>();
            int lowerLimit = int.MinValue;
            int upperLimit = int.MaxValue;
            if (firstLine.Count > secondLine.Count)
            {
                lowerLimit = Math.Min(firstLine[firstLine.Count - 2], firstLine[firstLine.Count - 1]);
                upperLimit = Math.Max(firstLine[firstLine.Count - 2], firstLine[firstLine.Count - 1]);

            }
            else if (secondLine.Count > firstLine.Count)
            {
                lowerLimit = Math.Min(secondLine[0], secondLine[1]);
                upperLimit = Math.Max(secondLine[0], secondLine[1]);
                secondLine.RemoveAt(0);
                secondLine.RemoveAt(1);
            }
            int k = Math.Min(firstLine.Count, secondLine.Count);
            for (int i = 0; i < k; i++)
            {

                middleResult.Add(firstLine[i]);
                middleResult.Add(secondLine[secondLine.Count - 1 - i]);
            }
            middleResult.RemoveAll(x => (x <= lowerLimit || x >= upperLimit));
            middleResult.Sort();
            Console.WriteLine(string.Join(" ", middleResult));

        }
    }
}
