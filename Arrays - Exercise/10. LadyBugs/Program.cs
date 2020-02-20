using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeLadeBugArray = int.Parse(Console.ReadLine());
            int[] ladyBugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] output = new int[sizeLadeBugArray];

            for (int i = 0; i < output.Length; i++)
            {
                if (ladyBugIndexes.Contains(i)) output[i] = 1;
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandToArray = command.Split();
                int leftNum = int.Parse(commandToArray[0]);
                string leftOrRight = commandToArray[1];
                int rightNum = int.Parse(commandToArray[2]);
                if ((leftNum >= 0) && (leftNum < sizeLadeBugArray) && (output[leftNum] == 1))
                {
                    output[leftNum] = 0;

                    if (leftOrRight == "right")
                    {
                        while ((leftNum + rightNum < sizeLadeBugArray) && (leftNum + rightNum >= 0))
                        {
                            if (output[leftNum + rightNum] == 0)
                            {
                                output[leftNum + rightNum] = 1;
                                break;
                            }
                            else leftNum += rightNum;
                        }
                    }
                    else if (leftOrRight == "left")
                    {
                        while ((leftNum - rightNum >= 0) && (leftNum - rightNum < sizeLadeBugArray))
                        {
                            if (output[leftNum - rightNum] == 0)
                            {
                                output[leftNum - rightNum] = 1;
                                break;
                            }
                            else
                            {
                                leftNum -= rightNum;
                            }
                        }
                    }
                    else
                    {
                        output[leftNum] = 1;
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var item in output)
            {
                Console.Write(item + " ");
            }

        }
    }
}
