using System;
using System.Net.Security;
using System.Text.RegularExpressions;

namespace _01._Arriving_in_Kathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^([A-Za-z0-9!@#$?]+)=(\d+)<<(.+)";

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Last note")
                {
                    break;
                }

                var regex = new Regex(pattern);
                var match = regex.Match(command);
                if (match.Success)
                {
                    var name = match.Groups[1].Value;
                    var length = int.Parse(match.Groups[2].Value);
                    var code = match.Groups[3].Value;
                    if (length == code.Length)
                    {
                        Console.WriteLine($"Coordinates found! {EncryptedName(name.ToCharArray())} -> {code}");
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

        static string EncryptedName(char[] name)
        {
            var peak = string.Empty;
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsLetterOrDigit(name[i]))
                {
                    peak += name[i];
                }
            }
            return peak;
        }
    }
}
