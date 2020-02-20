using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            int lenght = numbers.Count;
            int index = 0;
            int numberOfIndex = 0;
            List<int> newList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                newList.Add(numbers[i]);
            }
            while (command != "end")
            {
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "Contains":
                        index = int.Parse(tokens[1]);
                        CheckingContainsInList(numbers, index);
                        break;
                    case "PrintEven":
                        PrintEvenNumbers(numbers);
                        break;
                    case "PrintOdd":
                        PrintOddNumbers(numbers);
                        break;
                    case "GetSum":
                        GetSumOfList(numbers);
                        break;
                    case "Filter":
                        index = int.Parse(tokens[2]);
                        FilterCondition(numbers, tokens[1], index);
                        break;
                    case "Add":
                        index = int.Parse(tokens[1]);
                        newList.Add(index);
                        break;
                    case "Remove":
                        index = int.Parse(tokens[1]);
                        newList.Remove(index);
                        break;
                    case "RemoveAt":
                        index = int.Parse(tokens[1]);
                        newList.RemoveAt(index);
                        break;
                    case "Insert":
                        index = int.Parse(tokens[1]);
                        numberOfIndex = int.Parse(tokens[2]);
                        newList.Insert(numberOfIndex, index);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            //bool isEqual = false;
            //foreach (var item in numbers)
            //{
            //    if (newList.Contains(item))
            //    {
            //        isEqual = true;
            //    }
            //    else
            //    {
            //        isEqual = false;
            //        break;
            //    }
            //}
            if (newList.Count > 0 && newList.Count != lenght)
            {
                Console.WriteLine(string.Join(" ", newList));
            }
        }
        static void CheckingContainsInList(List<int> numbers, int index)
        {
            if (numbers.Contains(index))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        static void PrintEvenNumbers(List<int> numbers)
        {
            List<int> evenList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenList.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", evenList));
        }
        static void PrintOddNumbers(List<int> numbers)
        {
            List<int> evenList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    evenList.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", evenList));
        }
        static void GetSumOfList(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
        static void FilterCondition(List<int> numbers, string condtion, int index)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                newList.Add(numbers[i]);
            }
            if (condtion == ">=")
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    if (newList[i] < index)
                    {
                        newList.Remove(newList[i]);
                        i = -1;
                    }
                }
                Console.WriteLine(string.Join(" ", newList));
            }
            if (condtion == "<")
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    if (newList[i] > index)
                    {
                        newList.Remove(newList[i]);
                        i = -1;
                    }
                }
                Console.WriteLine(string.Join(" ", newList));
            }
            if (condtion == ">")
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    if (newList[i] < index)
                    {
                        newList.Remove(newList[i]);
                        i = -1;
                    }
                }
                Console.WriteLine(string.Join(" ", newList));
            }
            if (condtion == "<=")
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    if (newList[i] > index)
                    {
                        newList.Remove(newList[i]);
                        i = -1;
                    }
                }
                Console.WriteLine(string.Join(" ", newList));
            }
        }
    }
}
