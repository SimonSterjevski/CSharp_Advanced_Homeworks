using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public static class Word
    {
        public static List<string> Words = new List<string>();

        public static void AddWords()
        {
            Console.Clear();
            Console.WriteLine("Enter name");
            Console.WriteLine("Press x if you want to stop");
            string output = Console.ReadLine();
            if (output.ToLower() != "x")
            {
                Words.Add(output);
                AddWords();
            }
            else
            {
                if(Words.Count == 0)
                {
                    Console.WriteLine("No words to check. Press enter if you want to try again");
                    Console.ReadLine();
                    AddWords();
                }
            }
           
        }
        
    }
}
