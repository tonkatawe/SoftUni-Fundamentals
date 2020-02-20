using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            CharactersRange(a, b);
        }
        static void CharactersRange(char a, char b)
        {
            if (a > b)
            {
                for (char i = b; i < a; i++)
                {
                    if (i != b)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                for (char i = a; i < b; i++)
                {
                    if (i != a)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

        }
    }
}
