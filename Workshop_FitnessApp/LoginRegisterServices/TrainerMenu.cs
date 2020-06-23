using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodService
{
    public class TrainerMenu: IMenu
    {
        public void Train(Member user)
        {
            Console.WriteLine("Training started");
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
        public void RescheduleTraining()
        {
            Console.WriteLine("Training rescheduled!");
        }
    }
}
