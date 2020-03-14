using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace _02._Message_Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()); // number of commands
            string pattern = @"(?<name>\D)([A-Z][a-z]{2,})\k'name': \[?([A-z])\]\|\[?([A-z])\]\|\[?([A-z])\]\|$";
            var regex = new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                var someText = Console.ReadLine();
                var match = regex.Match(someText);
                if (match.Success)
                {
                    var firstNumber = (int)Convert.ToChar(match.Groups[2].Value);
                    var secondNumber = (int)Convert.ToChar(match.Groups[3].Value);
                    var thirdNumber = (int)Convert.ToChar(match.Groups[4].Value);
                    Console.WriteLine($"{match.Groups[1].Value}: {firstNumber} {secondNumber} {thirdNumber}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }

        }
    }
}
