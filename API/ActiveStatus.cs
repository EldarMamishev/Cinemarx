using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public static class ActiveStatus
    {
        public static PersonEntity ActiveUser { get; private set; }

        public static void UserChanged(PersonEntity newUser)
        {
            ActiveUser = newUser;
        }
    }
}
