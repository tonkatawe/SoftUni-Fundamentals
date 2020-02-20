using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeString = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] array = new int[sizeString];
            for (int i = 0; i < sizeString; i++)
            {
                string name = Console.ReadLine();

                int lenght = name.Length;

                for (int k = 0; k < name.Length; k++)
                {
                    char letter = name[k];
                    if (letter == 'a' || letter == 'e' || letter == 'o' || letter == 'i' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'O' || letter == 'I' || letter == 'U')
                    {
                        sum += letter * lenght;
                    }
                    else
                    {
                        sum += letter / lenght;
                    }
                }
                array[i] = sum;
                sum = 0;
            }
            Array.Sort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}

