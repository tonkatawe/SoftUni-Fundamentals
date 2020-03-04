using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string result = command;

            while (command != "For Azeroth")
            {
                var tokens = command.Split(" ");
                var text = tokens[0];
                if (text == "GladiatorStance")
                {
                    Console.WriteLine(text.ToUpper());
                }
                else if (text == "DefensiveStance")
                {
                    Console.WriteLine(text.ToLower());
                }
                else if (text == "Dispel")
                {
                    var index = int.Parse(tokens[1]);
                    char letter = char.Parse(tokens[2]);
                    if (index <= result.Length)
                    {
                        result = result.Replace(result[index], letter);
                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                }
                else if (text == "Target")
                {
                    if (tokens[1] == "Change") // might be have to check contains
                    {
                        var substring = tokens[2];
                        var substringNew = tokens[3];
                        result = result.Replace(substring, substringNew);
                        Console.WriteLine(result);

                    }
                    else if (tokens[1] == "Remove")
                    {
                        var substring = tokens[2];

                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
                command = Console.ReadLine();
            }

        }
    }
}
