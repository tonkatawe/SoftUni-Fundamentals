using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i <= input - 1; i++)
            {
                for (int k = 0; k <= input - 1; k++)
                {
                    for (int l = 0; l <= input - 1; l++)
                    {
                        char firstCh = (char)('a' + i);
                        char secondCh = (char)('a' + k);
                        char thirdCh = (char)('a' + l);
                        Console.WriteLine($"{firstCh}{secondCh}{thirdCh}");
                    }
                }
            }
        }
    }
}
