using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Generate")
                {
                    break;
                }

                var tokens = command.Split(">>>");
                var instructions = tokens[0];
                if (instructions == "Contains")
                {
                    var substring = tokens[1];
                    if (input.Contains(substring))
                    {
                        Console.WriteLine($"{input} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (instructions == "Flip")
                {
                    var upperOrLower = tokens[1];
                    var startIndex = int.Parse(tokens[2]);
                    var endIndex = int.Parse(tokens[3]); //here might be check for valid index but I am not sure
                    if (upperOrLower == "Upper")
                    {
                        var count = endIndex - startIndex;
                        var current = input.Substring(startIndex, count).ToUpper();
                        input = input.Remove(startIndex, count);
                        input = input.Insert(startIndex, current);

                        Console.WriteLine(input);
                    }
                    else if (upperOrLower == "Lower")
                    {
                        var count = endIndex - startIndex;
                        var current = input.Substring(startIndex, count).ToLower();
                        input = input.Remove(startIndex, count);
                        input = input.Insert(startIndex, current);

                        Console.WriteLine(input);
                    }
                }
                else if (instructions == "Slice")
                {
                    var startIndex = int.Parse(tokens[1]);
                    var endIndex = int.Parse(tokens[2]);
                    var count = endIndex - startIndex;
                    input = input.Remove(startIndex, count);
                    Console.WriteLine(input);
                }
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
