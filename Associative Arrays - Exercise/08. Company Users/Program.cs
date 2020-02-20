using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            while (command != "End")
            {
                string[] tokens = command.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string companyName = tokens[0];
                string employeeID = tokens[1];
                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(employeeID);
                }
                else
                {
                    if (!companies[companyName].Contains(employeeID))
                    {
                        companies[companyName].Add(employeeID);
                    }

                }
                command = Console.ReadLine();

            }
            foreach (var company in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }

        }
    }
}
