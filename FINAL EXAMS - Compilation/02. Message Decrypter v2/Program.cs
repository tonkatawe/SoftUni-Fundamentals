using System;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _02._Message_Decrypter_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()); ///number of string to encrypt
            var pattern = @"^(?<sign>%|\$)([A-Z][a-z]{2,})\k'sign': \[?([0-9]*)\]\|\[?([0-9]*)\]\|\[?([0-9]*)\]\|$";
            var regex = new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                var someText = Console.ReadLine();
                var match = regex.Match(someText);
                if (match.Success)
                {
                    var first = (char)int.Parse(match.Groups[2].Value);
                    var second = (char)int.Parse(match.Groups[3].Value);
                    var third = (char)int.Parse(match.Groups[4].Value);
                    Console.WriteLine($"{match.Groups[1].Value}: {first}{second}{third}");
                }
                else
                {
                    Console.WriteLine($"Valid message not found!");
                }

            }
        }
    }
}
