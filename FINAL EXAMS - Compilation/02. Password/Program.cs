using System;
using System.Text.RegularExpressions;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            //have to check 60/100
            var numberOfPasswd = int.Parse(Console.ReadLine());
            var pattern = @"(?<symbols>\w*?\W*)(>)(\d{3})\|([a-z]{3})\|([A-Z]{3})\|(\D{3})(<)\k<symbols>";
            for (int i = 0; i < numberOfPasswd; i++)
            {
                var password = Console.ReadLine();
                var regex = new Regex(pattern);
                var match = regex.Match(password);
                if (match.Success)
                {
                    Console.WriteLine($"Password: {match.Groups[2].Value}{match.Groups[3].Value}{match.Groups[4].Value}{match.Groups[5].Value}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
         }
    }
}
