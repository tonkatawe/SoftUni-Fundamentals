using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            SumOfTwoLists(firstList, secondList);

        }
        static void SumOfTwoLists(List<int> first, List<int> second)
        {
            int firstLenght = first.Count;
            int secondLenght = second.Count;
            List<int> sum = new List<int>();
            if (firstLenght < secondLenght)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    sum.Add(first[i]);
                    sum.Add(second[i]);
                    second.Remove(second[i]);
                    first.Remove(first[i]);
                    i = -1;
                }
                for (int i = 0; i < second.Count; i++)
                {
                    sum.Add(second[i]);
                }
            }
            else
            {
                for (int i = 0; i < second.Count; i++)
                {
                    sum.Add(first[i]);
                    sum.Add(second[i]);
                    second.Remove(second[i]);
                    first.Remove(first[i]);
                    i = -1;
                }
                for (int i = 0; i < first.Count; i++)
                {
                    sum.Add(first[i]);
                }
            }
            Console.Write(string.Join(" ", sum));
        }
    }
}
