using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            while (true)
            {
                var command = Console.ReadLine();
                var tokens = command.Split();
                if (tokens[0] == "Case")
                {
                    var instruction = tokens[1];
                    if (instruction == "lower")
                    {
                        username = username.ToLower();
                        Console.WriteLine(username);
                    }
                    else if (instruction == "upper")
                    {
                        username = username.ToUpper();
                        Console.WriteLine(username);
                    }
                }
                else if (tokens[0] == "Reverse")
                {
                    var startIndex = int.Parse(tokens[1]);
                    var endIndex = int.Parse(tokens[2]);
                    if (startIndex >=0 && endIndex < username.Length && endIndex > startIndex)
                    {
                        var temp = username.Substring(startIndex, endIndex); //here might use loop
                        var newtemp = temp.ToCharArray().Reverse();
                      //  Array.Reverse(newtemp);
                        Console.WriteLine(string.Join("",newtemp));
                    }

                }
                else if (tokens[0] == "Cut")
                {
                    var substring = tokens[1];
                    if (username.Contains(substring))
                    {
                      //to be continue;

                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {substring}.");
                    }
                }

            }
        }
    }
}
