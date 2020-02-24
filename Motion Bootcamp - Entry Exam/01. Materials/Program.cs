using System;

namespace _01._Materials
{
    class Program
    {
        static void Main(string[] args)
        {
            uint startYield = uint.Parse(Console.ReadLine());
            uint spiceMined = 0;
            uint daysOperated = 0;

            //while (startYield >= 100)
            //{
            //    spiceMined += startYield - 26;
            //    startYield -= 10;
            //    daysOperated++;
            //}
            //if (spiceMined != 0)
            //{
            //    spiceMined -= 26;
            //}
            while (startYield > 0  )
            {
                if (startYield >0 && startYield<100)
                {
                    if (spiceMined <= 26)
                    {
                        break;
                    }
                    spiceMined -= 26;
                    break;
                }
                else if (startYield >= 100)
                {
                    spiceMined += startYield - 26;
                    startYield -= 10;

                    daysOperated++;
                }
            }

            Console.WriteLine(daysOperated);
            Console.WriteLine(spiceMined);
        }
    }
}
