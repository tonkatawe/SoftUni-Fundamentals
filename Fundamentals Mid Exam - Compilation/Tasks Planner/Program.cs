using System;
using System.Linq;

namespace Tasks_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasks = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while (command != "End")
            {
                var tokens = command.Split(' ');
                var instructions = tokens[0];
                if (instructions == "Complete")
                {
                    var index = int.Parse(tokens[1]);
                    if (index >= 0 && index <= tasks.Length - 1)
                    {
                        tasks[index] = 0;
                    }
                }
                else if (instructions == "Change")
                {
                    var index = int.Parse(tokens[1]);
                    var taskTime = int.Parse(tokens[2]);
                    if (index >= 0 && index <= tasks.Length - 1) //here is posible to make if for newTime >=1 || 5<=
                    {
                        tasks[index] = taskTime;
                    }
                }
                else if (instructions == "Drop")
                {
                    var index = int.Parse(tokens[1]);
                    if (index >= 0 && index <= tasks.Length) //here is posible to make if for is it index -1
                    {
                        tasks[index] = -1;
                    }
                }
                else if (instructions == "Count")
                {
                    var typeOfCount = tokens[1];
                    var counter = 0;
                    if (typeOfCount == "Completed")
                    {
                        foreach (var task in tasks)
                        {
                            if (task == 0)
                            {
                                counter++;
                            }
                        }
                    }
                    else if (typeOfCount == "Incomplete")
                    {
                        foreach (var task in tasks)
                        {
                            if (task > 0) //here is possibe to make if for task 5 <=
                            {
                                counter++;
                            }
                        }
                    }
                    else if (typeOfCount == "Dropped")
                    {
                        foreach (var task in tasks)
                        {
                            if (task < 0) //here is possibe to make if for task 5 <=
                            {
                                counter++;
                            }
                        }
                    }
                    Console.WriteLine(counter);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", tasks.Where(x => x > 0)));
        }
    }
}
