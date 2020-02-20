using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                PalindromInteger(command);
                command = Console.ReadLine();
            }
        }
        static void PalindromInteger(string integer)
        {
            string forward = string.Empty;
            for (int i = 0; i < integer.Length; i++)
            {
                forward += integer[i];
            }
            string backward = string.Empty;
            for (int i = integer.Length - 1; i >= 0; i--)
            {
                backward += integer[i];
            }
            if (forward == backward)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
