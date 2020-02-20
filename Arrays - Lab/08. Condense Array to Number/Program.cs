using System;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputToArr = input.Split();
            int[] nums = new int[inputToArr.Length];
            int[] condensed = new int[nums.Length - 1];
            int length = nums.Length;
            for (int i = 0; i < inputToArr.Length; i++)
            {
                nums[i] = int.Parse(inputToArr[i]);
            }
            while (length > 1)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                    nums[i] = condensed[i];
                }
                length--;
            }
            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);

            }
            else
            {
                Console.WriteLine(nums[0]);
            }
        }
    }
}
