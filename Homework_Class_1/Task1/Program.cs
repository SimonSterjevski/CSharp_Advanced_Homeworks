using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    class Program
    {
        static List<string> words = new List<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter name");
                Console.WriteLine("Press x if you want to stop");
                string output = Console.ReadLine();
                if (output.ToLower() == "x")
                {
                    break;
                }
                words.Add(output);
            }
            if (words.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Enter text that you want to be checked");
                string text = Console.ReadLine();
                words.ForEach(word => ServiceMethod.ReturnInfo(text, word));
                Console.ReadLine();
            }
        }

    }
    }

