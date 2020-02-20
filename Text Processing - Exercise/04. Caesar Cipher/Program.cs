using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string newText = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char currChar = (char)(input[i] + 3);
                newText += currChar;
            }
            Console.WriteLine(newText.ToString());
        }



    }
}
