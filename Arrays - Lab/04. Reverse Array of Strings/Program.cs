using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] normal = text.Split();
            string[] reversNormal = new string[normal.Length];

            for (int i = normal.Length - 1; i >= 0; i--)
            {
                reversNormal[i] = normal[i];
                Console.Write(reversNormal[i] + " ");
            }
        }
    }
}
