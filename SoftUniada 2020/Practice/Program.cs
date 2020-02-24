using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m1 = n / 2;
            int m2 = 2 * n - 2 * m1 - 4;
            char a = ' ';
            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', m1), new string('_', m2));
            for (int i = 0; i <= n - 3; i++)
            {
                Console.Write("|{0}{1}{0}|", new string(' ', n / 2 + 1), new string(a, m2));
                Console.WriteLine();
                if (i == n - 4)
                {
                    a = '_';
                }
            }
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', m1), new string(' ', m2));
        }
    }
}