using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ")
                .ToList();
            string command = Console.ReadLine();
            while (command != "course start")
            {
                string[] tokens = command.Split(':');
                string action = tokens[0];
                string lesson = tokens[1];
                switch (action)
                {
                    case "Add":
                        if (!schedule.Contains(lesson))
                        {
                            schedule.Add(lesson);
                        }
                        break;
                    case "Insert":
                        int position = int.Parse(tokens[2]);
                        if (!schedule.Contains(lesson) && position <= schedule.Count)
                        {
                            schedule.Insert(position, lesson);
                        }
                        break;
                    case "Remove":
                        if (schedule.Contains(lesson))
                        {
                            schedule.Remove(lesson);
                        }
                        break;
                    case "Swap":
                        string newLesson = tokens[2];
                        if (schedule.Contains(lesson) && schedule.Contains(newLesson))
                        {
                            for (int i = 0; i < schedule.Count; i++)
                            {
                                if (schedule[i] == lesson)
                                {
                                    schedule[i] = newLesson;
                                    if (schedule.Contains($"{newLesson}-Exercise") && i + 1 <= schedule.Count)
                                    {
                                        schedule.Remove($"{newLesson}-Exercise");
                                        schedule.Insert(i + 1, $"{newLesson}-Exercise");
                                    }
                                }
                                else if (schedule[i] == newLesson)
                                {
                                    schedule[i] = lesson;
                                }
                            }
                        }
                        break;
                    case "Exercise":
                        if (schedule.Contains(lesson) && !schedule.Contains($"{lesson}-Exercise"))
                        {
                            for (int i = 0; i < schedule.Count; i++)
                            {
                                if (schedule[i] == lesson)
                                {
                                    schedule.Insert(i + 1, $"{lesson}-Exercise");
                                }
                            }
                        }
                        else if (!schedule.Contains(lesson))
                        {
                            schedule.Add(lesson);
                            schedule.Add($"{lesson}-Exercise");
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            int counter = 0;
            foreach (var lesson in schedule)
            {
                counter++;
                Console.WriteLine($"{counter}.{lesson}");
            }
        }
    }
}
