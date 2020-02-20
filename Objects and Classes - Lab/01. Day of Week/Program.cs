using System;
using System.Globalization;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string someDate = Console.ReadLine();
            DateTime data = DateTime.ParseExact(someDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(data.DayOfWeek);

        }
    }
}
