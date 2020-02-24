using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Deck_Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLenght = int.Parse(Console.ReadLine());
            int[] arrIndexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            List<int> cards = new List<int>();
            for (int i = 1; i <= arrLenght; i++)
            {
                cards.Add(i);
            }
            for (int i = 0; i < arrIndexes.Length; i++)
            {
                int indexForSeparation = arrIndexes[i];
                cards = SeparationArr(cards, indexForSeparation);
            }
            Console.WriteLine(string.Join(" ", cards));
        }
        static List<int> SeparationArr(List<int> cards, int indexForSeparation)
        {
            List<int> first = new List<int>();
            List<int> second = new List<int>();
            List<int> sum = new List<int>();

            for (int i = 0; i < cards.Count; i++)
            {
                if (i >= indexForSeparation)
                {
                    second.Add(cards[i]);
                }
                else
                {
                    first.Add(cards[i]);
                }
            }
            int firstLenght = first.Count;
            int secondLenght = second.Count;

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
            return cards = sum;
        }
    }
}
