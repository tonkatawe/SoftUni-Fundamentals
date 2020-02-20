using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int num = 0;
            int sum = 0;
            bool isSpecialNum = false;
            for (int ch = 1; ch <= input; ch++)
            {
                sum = ch;
                while (ch > 0)
                {
                    num += ch % 10;
                    ch = ch / 10;
                }
                isSpecialNum = (num == 5) || (num == 7) || (num == 11);
                Console.WriteLine("{0} -> {1}", sum, isSpecialNum);
                num = 0;
                ch = sum;
            }

        }
    }
}
