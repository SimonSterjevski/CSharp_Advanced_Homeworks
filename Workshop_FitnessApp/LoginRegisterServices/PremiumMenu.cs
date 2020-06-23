using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodService
{
    public class PremiumMenu: IMenu
    {
        public void Train(Member user)
        {
            if (user is PremiumUser premium)
            {
                if (premium.LiveTrainingUsed == true)
                {
                    Console.WriteLine("Video training started");
                }
                else
                {
                    Console.WriteLine("Press Y if you want to go live. Any other key for video training");
                    string answer = Console.ReadLine();
                    if (answer == "y" || answer == "Y")
                    {
                        Console.WriteLine("Live Training started");
                        premium.LiveTrainingUsed = true;
                    }
                    else
                    {
                        Console.WriteLine("Video training started");
                    }
                }
            }
           
           
        }
        public void SeeAcount(Member user)
        {
            Console.WriteLine($"ID number: {user.ID}");
            Console.WriteLine($"User: {user.FullName}");
            Console.WriteLine($"Role: {user.MemberRole}");
        }
        public void Logout(Member user)
        {
            user.IsLogged = false;
        }
    }
}
