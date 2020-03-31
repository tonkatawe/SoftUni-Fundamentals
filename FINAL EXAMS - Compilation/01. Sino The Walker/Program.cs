using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.VisualBasic;

namespace _01._Sino_The_Walker
{
    class Program
    {
        //I have only 80/100 by judge but I don't know why ?! I tried to make if checks for steps and seconds but it doesn't matter
        static void Main(string[] args)
        {
            //input
            var inputTime = Console.ReadLine();
            var steps = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());
            //problem solve

            var secondsPerStep = steps * seconds;

            string dataFromat = "HH:mm:ss";
            DateTime time = DateTime.ParseExact(inputTime, dataFromat, null);
            string result = time.AddSeconds(secondsPerStep).ToString(dataFromat);
            Console.WriteLine($"Time Arrival: {result}");

        }
    }
}
