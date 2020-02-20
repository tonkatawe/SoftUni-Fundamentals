using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();

            List<int> digitsList = new List<int>();
            List<string> nonDigitsList = new List<string>();

            StringBuilder results = new StringBuilder();

            List<int> takeList = new List<int>(); // List with even index from digitList
            List<int> skipList = new List<int>(); // List with odd index from digitList
            for (int i = 0; i < textInput.Length; i++)
            {
                if (char.IsDigit(textInput[i]))
                {
                    digitsList.Add(int.Parse(textInput[i].ToString()));
                }
                else
                {
                    nonDigitsList.Add(textInput[i].ToString());
                }
            }
            for (int i = 0; i < digitsList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digitsList[i]);
                }
                else
                {
                    skipList.Add(digitsList[i]);
                }
            }
            int startIndex = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = new List<string>(nonDigitsList);
                temp = temp.Skip(startIndex).Take(takeList[i]).ToList();

                results.Append(string.Join("", temp));
                startIndex += takeList[i] + skipList[i];

            }
            Console.WriteLine(results.ToString());
        }

    }
}
