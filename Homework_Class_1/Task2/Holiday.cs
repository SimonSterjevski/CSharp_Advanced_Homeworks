using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public static class Holiday
    {
         public static List<DateTime> Holidays = new List<DateTime>()
        {
            new DateTime(2020, 1, 1),
            new DateTime(2020, 1, 7),
            new DateTime(2020, 4, 20),
            new DateTime(2020, 5, 1),
            new DateTime(2020, 5, 24),
            new DateTime(2020, 8, 3),
            new DateTime(2020, 9, 8),
            new DateTime(2020, 10, 12),
            new DateTime(2020, 12, 8),
        };

        public static void WorkingDayInfo(DateTime? date)
        {
            Console.Clear();
            if (Holidays.Contains(date.Value) || date.Value.DayOfWeek == DayOfWeek.Saturday || date.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine($"You don't have to go to work on {date.Value.DayOfWeek}, {date.Value.Day}.{date.Value.Month}");
            }
            else
            {
                Console.WriteLine($"Lucky you! You have to work on {date.Value.DayOfWeek}, {date.Value.Day}.{date.Value.Month}");
            }
        }
    }
}
