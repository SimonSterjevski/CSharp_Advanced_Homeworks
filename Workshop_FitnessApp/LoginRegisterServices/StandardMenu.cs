using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodService
{
    public class StandardMenu: IMenu
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
        public void UpgradeToPremium(StandardUser user)
        {
            RegisteredUsers.RegisteredUsersList.Add(new PremiumUser(user));
            Console.WriteLine("Upgraded to premium. Account update on next login");
            if (user is StandardUser)
            {
                RegisteredUsers.RegisteredUsersList.Remove(user);
            }
        }
    }
}
