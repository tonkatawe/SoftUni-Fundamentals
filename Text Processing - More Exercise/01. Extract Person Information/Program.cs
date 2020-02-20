using System;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = string.Empty;
            string age = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                for (int k = 0; k < text.Length; k++)
                {
                    if (text[k] == '@')
                    {
                        while (text[k] != '|')
                        {
                            k++;
                            if (char.IsLetter(text[k]))
                            {
                                name += text[k];
                            }
                        }
                    }
                    else if (text[k] == '#')
                    {
                        while (text[k] != '*')
                        {
                            k++;
                            if (char.IsDigit(text[k]))
                            {
                                age += text[k];
                            }
                        }
                    }
                }
                Console.WriteLine($"{name} is {age} years old.");
                name = string.Empty;
                age = string.Empty;

            }
        }
    }
}
