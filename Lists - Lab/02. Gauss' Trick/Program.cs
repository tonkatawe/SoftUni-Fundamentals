using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            SumGaussNumbers(numbers);

        }
        static void SumGaussNumbers(List<int> nums)
        {
            int length = nums.Count;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums.Count == 0 || nums.Count == 1)
                {
                    break;
                }
                int sum = nums[i] + nums[nums.Count - 1];
                nums.Remove(nums[nums.Count - 1]);
                nums.Remove(nums[i]);
                Console.Write(sum + " ");

                i = -1;
            }
            Console.Write(string.Join("", nums));
        }
    }
}
