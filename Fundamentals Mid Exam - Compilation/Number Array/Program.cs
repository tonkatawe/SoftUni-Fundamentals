using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Number_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersOfArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int arrIndex = 0;
            int arrValue = 0;
            int sumInArr = 0;
            while (command != "End")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "Switch")
                {
                    arrIndex = int.Parse(tokens[1]);
                    if (arrIndex < numbersOfArr.Length && arrIndex >= 0)
                    {
                        numbersOfArr[arrIndex] *= -1;
                    }
                }
                if (tokens[0] == "Change")
                {
                    arrIndex = int.Parse(tokens[1]);
                    arrValue = int.Parse(tokens[2]);
                    if (arrIndex < numbersOfArr.Length && arrIndex >= 0)
                    {
                        numbersOfArr[arrIndex] = arrValue;
                    }
                }
                if (tokens[0] == "Sum" && tokens[1] == "Negative")
                {
                    sumInArr = 0;
                    foreach (int negative in numbersOfArr)
                    {
                        if (negative <= 0)
                        {
                            sumInArr += negative;
                        }
                    }
                    Console.WriteLine(sumInArr);
                }
                if (tokens[0] == "Sum" && tokens[1] == "Positive")
                {
                    sumInArr = 0;
                    foreach (int positive in numbersOfArr)
                    {
                        if (positive > 0)
                        {
                            sumInArr += positive;
                        }
                    }
                    Console.WriteLine(sumInArr);
                }
                if (tokens[0] == "Sum" && tokens[1] == "All")
                {
                    sumInArr = 0;
                    foreach (int all in numbersOfArr)
                    {
                        sumInArr += all;
                    }
                    Console.WriteLine(sumInArr);
                }
                command = Console.ReadLine();
            }
            List<int> positiveList = new List<int>();
            foreach (int positive in numbersOfArr)
            {
                if (positive >= 0)
                {
                    positiveList.Add(positive);
                }
            }
            Console.WriteLine(string.Join(' ', positiveList));

        }
    }
}
