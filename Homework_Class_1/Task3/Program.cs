using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = null;
            while (answer != "3")
            {
                Console.WriteLine("Rock - Paper - Scissors");
                Console.WriteLine("1)Play  2)Stats  3)Exit");
                answer = Console.ReadLine();
                Console.Clear();
                switch (answer)
                {
                    case "1":
                        ServiceMethods.Play();
                        break;
                    case "2":
                        ServiceMethods.SeeStats();
                        break;
                    case "3":
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
