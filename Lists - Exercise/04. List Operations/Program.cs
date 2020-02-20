namespace _04_ListOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListOperations
    {
        public static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine().
                Split().
                Select(double.Parse).
                ToList();

            while (true)
            {
                var commands = Console.ReadLine();
                if (commands == "End")
                {
                    break;
                }
                var command = commands.Split();

                switch (command[0])
                {
                    case "Add":
                        listOfNumbers = AddedNumber(listOfNumbers, command);

                        break;

                    case "Remove":
                        listOfNumbers = RemovedNumber(listOfNumbers, command);
                        break;

                    case "Insert":
                        listOfNumbers = InsertedNumber(listOfNumbers, command);
                        break;

                    case "Shift":

                        switch (command[1])
                        {
                            case "left":
                                listOfNumbers = ShihtLeft(listOfNumbers, command);
                                break;

                            case "right":
                                listOfNumbers = ShiftRight(listOfNumbers, command);
                                break;
                        }
                        break;

                }

            }
            Console.WriteLine(string.Join(" ", listOfNumbers));
        }

        private static List<double> ShiftRight(List<double> listOfNumbers, string[] command)
        {
            var timesToShift = int.Parse(command[2]);

            for (int times = 0; times < timesToShift; times++)
            {
                var lastIndex = listOfNumbers.Count - 1;
                var lastNumber = listOfNumbers[lastIndex];
                for (int shift = lastIndex; shift >= 1; shift--)
                {
                    listOfNumbers[shift] = listOfNumbers[shift - 1];
                }
                listOfNumbers[0] = lastNumber;
            }
            return listOfNumbers;
        }

        private static List<double> ShihtLeft(List<double> listOfNumbers, string[] command)
        {
            var timesToShift = int.Parse(command[2]);



            for (int times = 0; times < timesToShift; times++)
            {
                var firstNumber = listOfNumbers[0];
                for (int shift = 0; shift < listOfNumbers.Count - 1; shift++)
                {

                    listOfNumbers[shift] = listOfNumbers[shift + 1];
                }
                listOfNumbers[listOfNumbers.Count - 1] = firstNumber;
            }
            return listOfNumbers;
        }

        private static List<double> InsertedNumber(List<double> listOfNumbers, string[] command)
        {
            var numberToInsert = int.Parse(command[1]);
            var index = int.Parse(command[2]);

            if (index < listOfNumbers.Count && index >= 0)
            {
                listOfNumbers.Insert(index, numberToInsert);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            return listOfNumbers;

        }

        private static List<double> RemovedNumber(List<double> listOfNumbers, string[] command)
        {
            var indexToRemove = int.Parse(command[1]);
            if (indexToRemove < listOfNumbers.Count && indexToRemove >= 0)
            {
                listOfNumbers.RemoveAt(indexToRemove);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            return listOfNumbers;

        }

        private static List<double> AddedNumber(List<double> listOfNumbers, string[] command)
        {
            var numberToAdd = int.Parse(command[1]);
            listOfNumbers.Add(numberToAdd);
            return listOfNumbers;
        }
    }
}