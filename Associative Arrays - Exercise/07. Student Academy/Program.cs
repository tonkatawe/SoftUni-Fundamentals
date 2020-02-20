using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> averageGrade = new Dictionary<string, List<double>>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                if (!averageGrade.ContainsKey(studentName))
                {
                    averageGrade.Add(studentName, new List<double>());
                    averageGrade[studentName].Add(studentGrade);
                }
                else
                {
                    averageGrade[studentName].Add(studentGrade);
                }
            }
            foreach (var student in averageGrade.OrderByDescending(x => x.Value.Sum() / x.Value.Count))
            {
                double sum = student.Value.Sum();
                double count = student.Value.Count;
                double average = sum / count;

                if (average >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {average:F2}");
                }
            }
        }
    }
}
