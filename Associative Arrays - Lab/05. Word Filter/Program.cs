﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {


            var words = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

        }
    }
}
