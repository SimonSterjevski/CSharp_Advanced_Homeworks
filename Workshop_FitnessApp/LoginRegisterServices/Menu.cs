using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodService
{
    public interface IMenu
    {
        void Train(Member user);
        void SeeAcount(Member user);
        void Logout(Member user);
    }
}
