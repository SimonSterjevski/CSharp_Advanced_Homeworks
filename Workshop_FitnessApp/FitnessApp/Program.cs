using MethodService;
using System;
using Entity;
using System.Collections.Generic;

namespace FitnessApp
{
    class Program
    {

        static void Main(string[] args)
        {
            RegisteredUsers.RegisteredUsersList.Add(new Trainer("Mark", "Bowl", "Mark123", "mark9", 1));

            while (true)
            {
                Member loggedUser = FitnessAppFlow.StartMenuOption();
                if (loggedUser is Member)
                {
                    FitnessAppFlow.ChooseAction(loggedUser);
                }
                if (loggedUser == null)
                {
                    break;
                }
                
            }
            //Console.ReadLine();
        }
    }
}
