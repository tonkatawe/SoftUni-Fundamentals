using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            int element = 0;
            int sum = 0;
            while (sequence.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    element = sequence[0];
                    sequence[0] = sequence[sequence.Count - 1];
                }
                else if (index >= sequence.Count)
                {
                    element = sequence[sequence.Count - 1];
                    sequence[sequence.Count - 1] = sequence[0];
                }
                else

                {
                    element = sequence[index];
                    sequence.RemoveAt(index);

                }
                sum += element; ;

                for (int i = 0; i < sequence.Count; i++)
                {

                    if (sequence[i] <= element)
                    {
                        sequence[i] += element;
                    }
                    else if (sequence[i] > element)
                    {
                        sequence[i] -= element;
                    }
                }


            }
            Console.WriteLine(sum);
        }
    }
}
