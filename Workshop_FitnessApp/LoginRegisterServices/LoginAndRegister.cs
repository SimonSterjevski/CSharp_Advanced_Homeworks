using Entity;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace MethodService
{
    public static class LoginAndRegister
    {
        public static Member Login()
        {
            int counter = 0;
            while (counter < 3)
            {
                Console.WriteLine("-----Login-----");
                Console.WriteLine("Enter your username:");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter your password");
                string pass = Console.ReadLine();
                foreach (Member user in RegisteredUsers.RegisteredUsersList)
                {
                    if (user.UserName == userName && user.Password == pass)
                    {
                        Console.Clear();
                        user.IsLogged = true;
                        return user;
                    }
                }
                if (counter != 2)
                {
                    Console.WriteLine("Wrong username or password! Try again");
                    Console.ReadLine();
                }
                Console.Clear();
                counter++;
            }
            if (counter > 2)
            {
                Console.Clear();
                return FitnessAppFlow.StartMenuOption();
            }
            return null;
        }
        public static void Register()
        {
            Console.WriteLine("-----Register-----");
            string firstName = QuestionValidator("Please insert your first name (2 or more characters)", 2);
            string lastName = QuestionValidator("Please insert your last name (2 or more characters)", 2);
            string userName = CheckUserName(RegisteredUsers.RegisteredUsersList, QuestionValidator("Please choose your username (6 or more characters)", 6));
            string pass = NumberCheck(QuestionValidator("Please choose your password (6 or more characters, at least 1 number)", 6));
            Console.WriteLine("Registration was succesful! Press any key to go back to start menu");
            Console.ReadLine();
            Console.Clear();
            RegisteredUsers.RegisteredUsersList.Add(new StandardUser(firstName, lastName, userName, pass));
        }

        public static string QuestionValidator(string question, int length)
        {
            Console.WriteLine(question);
            var name = Console.ReadLine();
            if (name.Length >= length)
            {
                return name;
            } 
            else
            {
                return QuestionValidator(question, length);
            }
        }

        public static string NumberCheck(string name)
        {
            var chars = name.ToCharArray();
            foreach (char letter in chars)
            {
                if (int.TryParse(letter.ToString(), out int num))
                {
                    return name;
                }
            }
            return NumberCheck(QuestionValidator("Please choose your password (6 or more characters, at least 1 number)", 6));
        }
        public static string CheckUserName(List<Member> users, string name)
        {
            foreach (Member user in users)
            {
                if (user.UserName == name)
                {
                    Console.WriteLine("Username is taken. Insert another one!");
                    return CheckUserName(users, QuestionValidator("Please choose your username (6 or more characters)", 6));
                }
            }
            return name;
        }
    }
}
