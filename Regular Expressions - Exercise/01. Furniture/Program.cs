using System;
using System.Text.RegularExpressions;
namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @">>([A-Za-z]+)<<(\d+\.?\d*)!(\d+)";
            Regex regex = new Regex(pattern);
            var input = Console.ReadLine();
            double totalSum = 0;
            Console.WriteLine("Bought furniture:");
            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    totalSum += double.Parse(match.Groups[2].Value) * int.Parse(match.Groups[3].Value);
                    Console.WriteLine(name);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {totalSum:F2}");
        }
    }
}
