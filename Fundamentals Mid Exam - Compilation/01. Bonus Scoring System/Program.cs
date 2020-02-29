using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfStudents = double.Parse(Console.ReadLine());
            double courseLectutres = double.Parse(Console.ReadLine());
            double bonus = double.Parse(Console.ReadLine());
            double totalBonus = 0;
            double maxStudent = double.MinValue;
            double curently = 0;
            if (numberOfStudents <= 50 && curently <= 100 && totalBonus <=100)
            {
                for (int i = 1; i <= numberOfStudents; i++)
                {
                    var studentAttendens = double.Parse(Console.ReadLine());
                    if (studentAttendens > 0)
                    {

                        totalBonus = (studentAttendens / courseLectutres) * (5 + bonus);
                        if (totalBonus >= maxStudent)
                        {
                            maxStudent = totalBonus;
                            curently = studentAttendens;
                        }
                    }
                }

                Console.WriteLine($"Max Bonus: {Math.Round(maxStudent)}.");
                Console.WriteLine($"The student has attended {curently} lectures.");

            }
        }
    }
}

