using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _02._Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCommands = int.Parse(Console.ReadLine());
            var pattern = @"^!([A-Z][a-z]{2,})!:\[([A-z]{8,})\]$";
            var regex = new Regex(pattern);
            for (int i = 0; i < numberOfCommands; i++)
            {
                var input = Console.ReadLine();
                var match = regex.Match(input);
                if (match.Success)
                {
                    byte[] ascii = Encoding.ASCII.GetBytes(match.Groups[2].Value);
                    Console.WriteLine($"{match.Groups[1].Value}: {string.Join(" ", ascii)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
