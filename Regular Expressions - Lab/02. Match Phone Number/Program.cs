using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+([359]+)([-| ])2(\2)(\d{3})(\2)(\d{4})\b";
            string inputNumbers = Console.ReadLine();
            var regex = Regex.Matches(inputNumbers, pattern);
            var machedPhone = regex.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", machedPhone));
        }
    }
}

