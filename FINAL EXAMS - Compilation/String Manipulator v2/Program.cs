using System;

namespace String_Manipulator_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var someText = Console.ReadLine();
            while (true)
            {
                var tokens = Console.ReadLine().Split();
                var instruction = tokens[0];
                if (instruction == "Translate")
                {
                    var oldChar = tokens[1];
                    var newChar = tokens[2];
                    if (someText.Contains(oldChar))
                    {
                        someText = someText.Replace(oldChar, newChar);
                        Console.WriteLine(someText);
                    }
                }
                else if (instruction == "Includes")
                {
                    var currentString = tokens[1];
                    if (someText.Contains(currentString))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (instruction == "Start")
                {
                    var currentString = tokens[1];
                    var temp = someText.Substring(0, currentString.Length);
                    if (temp == currentString)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (instruction == "Lowercase")
                {
                    someText = someText.ToLower();
                    Console.WriteLine(someText);
                }
                else if (instruction == "FindIndex")
                {
                    var currentChar = char.Parse(tokens[1]);
                    if (someText.Contains(currentChar))
                    {
                        for (int i = someText.Length - 1; i >= 0; i--)
                        {
                            if (someText[i] == currentChar)
                            {
                                Console.WriteLine(i);
                                break;
                            }
                        }
                    }
                }
                else if (instruction == "Remove")
                {
                    var startIndex = int.Parse(tokens[1]);
                    var count = int.Parse(tokens[2]);
                    if (startIndex >=0 && count < someText.Length && count > startIndex)
                    {
                        someText = someText.Remove(startIndex, count);
                        Console.WriteLine(someText);
                    }
                }
                else if (instruction == "End")
                {
                    break;
                }
            }
        }
    }
}
