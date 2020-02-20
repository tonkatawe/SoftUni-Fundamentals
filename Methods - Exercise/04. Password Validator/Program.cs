using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool passwordLenght = PasswordLenght(text);
            bool passwerdLetterAndDigits = PasswordLetterAndDigits(text);
            bool digitCounter = DigitCounter(text);
            if (passwerdLetterAndDigits && passwordLenght && digitCounter)
            {
                Console.WriteLine("Password is valid");
            }
            if (!passwordLenght)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!passwerdLetterAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!digitCounter)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
        private static bool PasswordLenght(string text)
        {
            bool length = false;
            int n = text.Length;
            if (n < 6 || n > 10)
            {
                length = false;
            }
            else
            {
                length = true;
            }
            return length;

        }
        private static bool PasswordLetterAndDigits(string text)
        {
            bool letter = false;
            for (int i = 0; i <= text.Length - 1; i++)
            {
                char currentLetter = text[i];
                if ((currentLetter < 48 || currentLetter > 57) && (currentLetter < 65 || currentLetter > 90) && (currentLetter < 97 || currentLetter > 122))
                {
                    letter = false;
                    break;
                }
                else
                {
                    letter = true;
                }
            }
            return letter;
        }
        static bool DigitCounter(string text)
        {
            bool digitCounter = false;
            int counter = 0;
            for (int i = 0; i <= text.Length - 1; i++)
            {
                char currentLetter = text[i];
                if (currentLetter >= 48 && currentLetter < 57)
                {
                    counter++;
                }
            }
            if (counter < 2)
            {
                digitCounter = false;
            }
            else
            {
                digitCounter = true;
            }
            return digitCounter;
        }



    }
}
