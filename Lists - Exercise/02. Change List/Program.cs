using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            int index = 0;
            int numberOfIndex = 0;
            while (command != "end")
            {
                string[] typeOfCommand = command.Split();
                switch (typeOfCommand[0])
                {
                    case "Delete":
                        index = int.Parse(typeOfCommand[1]);
                        DeleteAllElements(numbers, index);
                        break;
                    case "Insert":
                        index = int.Parse(typeOfCommand[1]);
                        numberOfIndex = int.Parse(typeOfCommand[2]);
                        numbers.Insert(numberOfIndex, index);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void DeleteAllElements(List<int> nums, int index)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == index)
                {
                    nums.Remove(nums[i]);
                    i--;
                }
            }
        }
    }
}
