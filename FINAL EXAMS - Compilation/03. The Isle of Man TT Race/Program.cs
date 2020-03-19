using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;

namespace _03._The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^(?<sing>\W)(\w+)\k'sing'=(\d*)!!(.*)";
            var regex = new Regex(pattern);
            while (true)
            {
                var input = Console.ReadLine();
                var match = regex.Match(input);
                if (match.Success)
                {
                    var name = match.Groups[1].Value;
                    var length = int.Parse(match.Groups[2].Value);
                    var text = match.Groups[3].Value;
                    if (text.Length == length)
                    {
                        Console.WriteLine($"Coordinates found! {name} -> {Encrypt(text.ToCharArray())}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }


            }
        }

        static string Encrypt(char[] text)
        {

            var newText = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                text[i] += (char)text.Length;
                newText += text[i];
            }
            return newText;
        }
    }
}
