using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class PremiumUser: Member
    {
        public bool LiveTrainingUsed { get; set; }
        public PremiumUser(StandardUser user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            UserName = user.UserName;
            Password = user.Password;
            MemberRole = RoleEnum.premium;
            IsLogged = false;
            LiveTrainingUsed = false;
        }
    }
}
