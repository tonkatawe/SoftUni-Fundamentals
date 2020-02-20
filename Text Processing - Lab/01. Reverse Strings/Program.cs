using System;
using System.Text;
namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            while (word != "end")
            {
                string reversWord = string.Empty;
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversWord += word[i];
                }
                Console.WriteLine($"{word} = {reversWord}");
                word = Console.ReadLine();
            }
        }
    }
}
