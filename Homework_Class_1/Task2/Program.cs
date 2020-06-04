using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DateTime? date = UserFlow.Flow();
                if (date != null)
                {
                    Console.Clear();
                    if (Holiday.Holidays.Contains(date.Value) || date.Value.DayOfWeek == DayOfWeek.Saturday || date.Value.DayOfWeek == DayOfWeek.Sunday)
                    {
                        Console.WriteLine($"You don't have to go to work on {date.Value.DayOfWeek}, {date.Value.Day}.{date.Value.Month}");
                    }
                    else
                    {
                        Console.WriteLine($"Lucky you! You have to work on {date.Value.DayOfWeek}, {date.Value.Day}.{date.Value.Month}");
                    }
                    Console.WriteLine("Press Y if you want to check another date? Any other key to leave");
                    string answer = Console.ReadLine().ToLower();
                    if (answer != "y")
                    {
                        break;
                    }
                } else
                {
                    break;
                }
                
            }
           
           
        }
    }
}
