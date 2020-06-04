using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public static class UserFlow
    {
        public static DateTime? Flow()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("2020 Working day cheker :)");
                Console.WriteLine("Please select day");
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine("Please select month number");
                int month = int.Parse(Console.ReadLine());
                DateTime date = new DateTime(2020, month, day);
                return date;
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Date is not valid! Press Y to try again! Any other key to leave");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    return Flow();
                }
                else
                {
                    return null;
                }
               
            }    
        }
    }
}
