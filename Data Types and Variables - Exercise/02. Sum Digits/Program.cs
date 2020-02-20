using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string sum = string.Empty;
            int total = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum = number[i].ToString();
                total += int.Parse(sum);
            }
            Console.WriteLine(total);
        }
    }
}
