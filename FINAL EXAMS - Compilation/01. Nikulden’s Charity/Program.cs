using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _01._Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (true)
            {
                string command = Console.ReadLine();
                var tokens = command.Split();
                if (tokens[0] == "Replace")
                {
                    var oldChar = tokens[1];
                    var newChar = tokens[2];
                    if (text.Contains(oldChar))
                    {
                        text = text.Replace(oldChar, newChar);
                        Console.WriteLine(text);
                    }
                }
                else if (tokens[0] == "Cut")
                {
                    var startIndex = int.Parse(tokens[1]);
                    var endIndex = int.Parse(tokens[2]);
                    if (startIndex >= 0 && startIndex <= endIndex && endIndex < text.Length && endIndex > 0)
                    {
                        var temp = string.Empty;
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            char currChar = text[i];
                            temp += currChar;
                        }
                        text = text.Remove(startIndex, temp.Length);
                        Console.WriteLine(text);

                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if (tokens[0] == "Make")
                {
                    if (tokens[1] == "Upper")
                    {
                        text = text.ToUpper();
                        Console.WriteLine(text);

                    }
                    else if (tokens[1] == "Lower")
                    {
                        text = text.ToLower();
                        Console.WriteLine(text);

                    }
                }
                else if (tokens[0] == "Check")
                {
                    var stringForCheck = tokens[1];
                    if (text.Contains(stringForCheck))
                    {
                        Console.WriteLine($"Message contains {stringForCheck}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {stringForCheck}");
                    }
                }
                else if (tokens[0] == "Sum")
                {
                    var startIndex = int.Parse(tokens[1]);
                    var endIndex = int.Parse(tokens[2]);
                    if (startIndex >= 0 && startIndex <= endIndex && endIndex < text.Length && endIndex > 0)
                    //here might be have to make diferent ifs
                    {
                        var sum = 0;
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            sum += (int)(text[i]);
                        }
                        Console.WriteLine(sum);

                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if (tokens[0] == "Finish")
                {
                    break;
                }
            }
        }
    }
}
