using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);
            MatchCollection matchedNames = regex.Matches(names);
            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
