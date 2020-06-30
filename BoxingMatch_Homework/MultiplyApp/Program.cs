using System;
using System.IO;

namespace MultiplyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("multiply.txt");
            StreamWriter sw1 = new StreamWriter("multiplytable.txt");

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    string result = $"{i} * {j} = {i * j}";
                    sw.WriteLine(result);
                }
            }
            sw.Close();


            sw1.WriteLine("  | 01 02 03 04 05 06 07 08 09 ");
            sw1.WriteLine("------------------------------");
            for (int i = 1; i < 10; i++)
            {
                if (i > 1)
                    sw1.WriteLine();
                string parsed = i.ToString();
                if (parsed.Length == 1)
                {
                    string newParsed = "0" + parsed + "|" + " ";
                    sw1.Write(newParsed);
                }
                else
                {
                    sw1.Write($" {i}");
                }
                for (int j = 1; j < 10; j++)
                {
                    string result = (i * j).ToString();
                    if (result.Length == 1)
                    {
                        string newResult = "0" + result + " ";
                        sw1.Write(newResult);
                    }
                    else
                    {
                        sw1.Write($"{i * j} ");
                    }

                }
            }
            sw1.Close();


            Console.WriteLine("  | 01 02 03 04 05 06 07 08 09 ");
            Console.WriteLine("------------------------------");
            for (int i = 1; i < 10; i++)
            {
                if (i > 1)
                    Console.WriteLine();
                string parsed = i.ToString();
                if (parsed.Length == 1)
                {
                    string newParsed = "0" + parsed + "|" + " ";
                    Console.Write(newParsed);
                }
                else
                {
                    Console.Write($" {i}");
                }
                for (int j = 1; j < 10; j++)
                {
                    string result = (i * j).ToString();
                    if (result.Length == 1)
                    {
                        string newResult = "0" + result + " ";
                        Console.Write(newResult);
                    }
                    else
                    {
                        Console.Write($"{i * j} ");
                    }

                }
            }

            Console.ReadLine();
        }
    }
}
