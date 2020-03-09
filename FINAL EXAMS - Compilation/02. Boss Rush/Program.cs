using System;
using System.Text.RegularExpressions;

namespace _02._Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCommands = int.Parse(Console.ReadLine());
            string pattern = @"^\|([A-Z]{3,})\|\:\#([A-z]+ [A-z]+)\#$"; 
            Regex regex = new Regex(pattern);
            for (int i = 0; i < numberOfCommands; i++)
            {
                var input = Console.ReadLine();
                var match = regex.Match(input);
                if (match.Success)
                {
                    Console.WriteLine($"{ match.Groups[1].Value}, The {match.Groups[2].Value}");
                    Console.WriteLine($">> Strength: {match.Groups[1].Length}");
                    Console.WriteLine($">> Armour: {match.Groups[2].Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }

        }
    }
}
