﻿using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = (int)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = (int)(days * 24);
            long minutes = (long)(hours * 60);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
