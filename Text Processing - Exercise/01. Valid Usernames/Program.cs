using System;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ");
            foreach (var item in text)
            {
                if (item.Length >= 3 && item.Length <= 16 && ChekForLetterOrDigit(item))
                {

                    Console.WriteLine(item);
                }
            }
        }
        static bool ChekForLetterOrDigit(string item)
        {

            foreach (var character in item)
            {
                if (!char.IsLetterOrDigit(character) && character != '_' && character != '-')
                {
                    return false;
                }

            }
            return true;
        }
    }
}
