using System;
using System.Collections;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "string":
                    string one = Console.ReadLine();
                    string two = Console.ReadLine();
                    Console.WriteLine(GetMax(one, two));
                    break;
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(a, b));
                    break;
                case "char":
                    char first = char.Parse(Console.ReadLine());
                    char second = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(first, second));
                    break;
                default:
                    break;
            }

        }
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static string GetMax(string text, string textTwo)
        {

            text.CompareTo(textTwo);
            return textTwo;
        }
    }
}
