using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public static class ServiceMethod
    {
        public static void ReturnInfo(string text, string name)
        {
            int count = 0;
            int i = 0;
            while ((i = text.ToLower().IndexOf(name.ToLower(), i)) != -1)
            {
                i += name.Length;
                count++;
            }
            Console.WriteLine($"{name} occurs {count} times in the {text}");
        }
    }
}
