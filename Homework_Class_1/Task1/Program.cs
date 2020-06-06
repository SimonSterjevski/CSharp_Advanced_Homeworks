using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Word.AddWords();
            if (Word.Words.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Enter text that you want to be checked");
                string text = Console.ReadLine();
                Word.Words.ForEach(word => ServiceMethod.ReturnInfo(text, word));
                Console.ReadLine();
            }
        }

    }
    }

