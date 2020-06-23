using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Entity
{
    public class StandardUser: Member
    {
        public StandardUser(string first, string last, string username, string pass)
        {
            FirstName = first;
            LastName = last;
            UserName = username;
            Password = pass;
            MemberRole = RoleEnum.standard;
            IsLogged = false;
            ID = RegisteredUsers.RegisteredUsersList.Select(member => member.ID).ToList().Last() + 1;
        }
    }
}
