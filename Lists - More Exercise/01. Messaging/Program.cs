using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string text = Console.ReadLine();
            for (int i = 0; i < numbers.Count; i++)
            {

                int currentNumber = numbers[i];
                int index = CalcIndex(currentNumber);
                char currentChar = GetCharFromMsg(index, text);
                Console.Write(currentChar);
                int realIndex = CalcRealIndex(index, text);
                string newText = text.Remove(realIndex, 1);
                text = newText;
            }

        }
        static int CalcRealIndex(int index, string text)
        {
            int countIndex = 0;
            for (int i = 0; i < index; i++)
            {
                countIndex++;
                if (countIndex == text.Length)
                {
                    countIndex = 0;
                }
            }
            return countIndex;
        }
        static char GetCharFromMsg(int index, string text)
        {
            int countIndex = 0;
            for (int i = 0; i < index; i++)
            {
                countIndex++;
                if (countIndex == text.Length)
                {
                    countIndex = 0;
                }
            }
            char currentChar = text[countIndex];
            return currentChar;
        }
        static int CalcIndex(int index)
        {
            int number = 0;
            while (index > 0)
            {
                int currentNumber = index % 10;
                number += currentNumber;
                index = index / 10;
            }
            return number;
        }
    }
}
