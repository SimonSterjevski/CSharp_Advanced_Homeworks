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
                DateTime? date = UserFlow.GetDate();
                if (date != null)
                {
                    Holiday.WorkingDayInfo(date);
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
