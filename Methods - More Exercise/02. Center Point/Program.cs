using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            CenterPoint(x1, y1, x2, y2);
        }
        static void CenterPoint(double x1, double y1, double x2, double y2)
        {
            double closedX = 0;
            double closedY = 0;
            if (x1 == x2)
            {
                closedX = x1;
            }
            else if (Math.Abs(x1) < Math.Abs(x2))
            {
                closedX = x1;
            }

            else
            {
                closedX = x2;
            }
            if (y1 == y2)
            {
                closedY = y2;
            }
            else if (Math.Abs(y1) < Math.Abs(y2))
            {
                closedY = y1;
            }
            else
            {
                closedY = y2;
            }
            Console.WriteLine($"({closedX}, {closedY})");
        }

    }
}
