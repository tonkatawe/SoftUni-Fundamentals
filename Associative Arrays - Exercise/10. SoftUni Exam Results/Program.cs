using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<int>> usersAndPoints = new Dictionary<string, List<int>>();
            Dictionary<string, List<int>> languagesAndSubmissions = new Dictionary<string, List<int>>();
            while (command != "exam finished")
            {
                string[] tokens = command.Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 3)
                {
                    string userName = tokens[0];
                    string language = tokens[1];
                    int counter = 1;
                    int points = int.Parse(tokens[2]);
                    if (!usersAndPoints.ContainsKey(userName))
                    {
                        usersAndPoints[userName] = new List<int>();
                        usersAndPoints[userName].Add(points);
                    }
                    else
                    {
                        usersAndPoints[userName].Add(points);
                    }
                    if (!languagesAndSubmissions.ContainsKey(language))
                    {
                        languagesAndSubmissions[language] = new List<int>();
                        languagesAndSubmissions[language].Add(counter);
                    }
                    else
                    {
                        languagesAndSubmissions[language].Add(counter++);
                    }

                }
                if (tokens.Length == 2)
                {
                    string userName = tokens[0];
                    if (usersAndPoints.ContainsKey(userName))
                    {
                        usersAndPoints.Remove(userName);
                    }
                }
                command = Console.ReadLine();

            }
            Console.WriteLine("Results:");
            foreach (var user in usersAndPoints.OrderByDescending(x => x.Value.Max()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value.Max()}");
            }
            Console.WriteLine("Submissions:");
            foreach (var language in languagesAndSubmissions.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value.Sum()}");
            }
        }
    }
}
