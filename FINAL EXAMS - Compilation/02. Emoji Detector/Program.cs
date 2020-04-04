using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = input.Split(); //split all words
            BigInteger coolThreshold = 1;
            var counter = 0;
            var successedMatch = new List<string>(); //save all currently maches

            foreach (var symbol in input) //use fore multiply all digits in string
            {
                if (char.IsDigit(symbol))
                {
                    coolThreshold *= int.Parse(symbol.ToString());
                }
            }


            Console.WriteLine($"Cool threshold: {coolThreshold}");
            var pattern = @"(?<num>\*{2}|:{2})([A-Z][a-z]{2,})\k'num'";
            var regex = new Regex(pattern);

            foreach (var word in data) //count all words in string and save all successed matches
            {
                var match = regex.Match(word);
                if (match.Success)
                {
                    successedMatch.Add(match.Value);
                    counter++;
                }
            }

            Console.WriteLine($"{counter} emojis found in the text. The cool ones are:");

            for (int i = 0; i < successedMatch.Count; i++)
            {
                BigInteger currentSum = 0;

                foreach (var symbol in successedMatch[i])
                {
                    if (char.IsLetter(symbol))
                    {
                        currentSum += (int)symbol;
                    }
                }

                if (currentSum > coolThreshold)
                {
                    Console.WriteLine(successedMatch[i]);
                }
            }




        }
    }
}
