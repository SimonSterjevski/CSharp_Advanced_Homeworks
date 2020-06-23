using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Trainer: Member
    {
       
        public Trainer(string first, string last, string username, string pass, int id)
        {
            FirstName = first;
            LastName = last;
            UserName = username;
            Password = pass;
            MemberRole = RoleEnum.trainer;
            IsLogged = false;
            ID = id;
        }
    }
}
