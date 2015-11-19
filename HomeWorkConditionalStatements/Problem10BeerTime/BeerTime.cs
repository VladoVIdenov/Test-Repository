﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Problem 10.	* Beer Time
//A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” 
//(an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” 
//according to the definition above or “invalid time” if the time cannot be parsed. 
//Note that you may need to learn how to parse dates and times.

namespace Problem10BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            CultureInfo info = new CultureInfo ("en-US");

            DateTime time;
            DateTime start = DateTime.Parse("1:00 PM");
            DateTime end = DateTime.Parse("3:00 AM");
            string inputTime = Console.ReadLine();

            if (DateTime.TryParseExact(inputTime, "h:mm tt", info, DateTimeStyles.None, out time))
            {
                if (time >= start || time < end )
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
