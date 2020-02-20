using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequencesOfText = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<double> middleResult = new List<double>();
            foreach (var item in sequencesOfText)
            {
                middleResult.Add(DivideNumber(item));

            }
            Console.WriteLine($"{middleResult.Sum():F2}");

        } // charAlphabet = char - 64;
        static double DivideNumber(string stringFromArray)
        {
            char currentChar = stringFromArray[0]; // get first letter
            char lastChar = stringFromArray[stringFromArray.Length - 1]; // get last letter
            double manipulator = 0;
            double secondManipulator = 0;
            string number = string.Empty;
            double factNumber = 0;
            for (int i = 0; i < stringFromArray.Length; i++)
            {
                if (char.IsDigit(stringFromArray[i]))
                {
                    number += stringFromArray[i];
                }

            }
            factNumber = int.Parse(number);
            if (stringFromArray[0] >= 'A' && stringFromArray[0] <= 'Z')
            {
                manipulator = (int)currentChar - 64;
                factNumber /= manipulator;
            }
            else if (stringFromArray[0] >= 'a' && stringFromArray[0] <= 'z')
            {
                manipulator = (int)currentChar - 96;
                factNumber *= manipulator;
            }
            if (stringFromArray[stringFromArray.Length - 1] >= 'A' && stringFromArray[stringFromArray.Length - 1] <= 'Z')
            {
                secondManipulator = (int)lastChar - 64;
                factNumber -= secondManipulator;
            }
            else if (stringFromArray[stringFromArray.Length - 1] >= 'a' && stringFromArray[stringFromArray.Length - 1] <= 'z')
            {
                secondManipulator = (int)lastChar - 96;
                factNumber += secondManipulator;
            }
            return factNumber;
        }
    }
}
