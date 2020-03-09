using System;
using System.Text.RegularExpressions;

namespace _02._Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfUsers = int.Parse(Console.ReadLine());
            string pattern = @"^U\$([A-Z][a-z]{2,})U\$P@\$([a-z]{5,}[0-9]+)P@\$$";
            var regex = new Regex(pattern);
            var counter = 0;
            for (int i = 0; i < numberOfUsers; i++)
            {
                var command = Console.ReadLine();
                var match = regex.Match(command);
                if (match.Success)
                {
                    counter++;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {match.Groups[1].Value}, Password: {match.Groups[2].Value}");

                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }

            }
            Console.WriteLine($"Successful registrations: {counter}");
        }
    }
}
