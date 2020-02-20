using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(string.Join(' ', input));


        }
    }
}

