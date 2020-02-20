using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double max = double.MinValue;
            string keg = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string typeKeg = Console.ReadLine();
                float radiusKeg = float.Parse(Console.ReadLine());
                double heightKeg = double.Parse(Console.ReadLine());
                double volomueKeg = (radiusKeg * radiusKeg * heightKeg * Math.PI);
                if (volomueKeg > max)
                {
                    max = volomueKeg;
                    keg = typeKeg;
                }

            }
            Console.WriteLine(keg);
        }
    }
}
