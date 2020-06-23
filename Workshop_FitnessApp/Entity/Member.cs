using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public abstract class Member
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get => $"{FirstName} {LastName}"; }
        public RoleEnum MemberRole { get; set; }
        public bool IsLogged { get; set; }
       
    }
}
