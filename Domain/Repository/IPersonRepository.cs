using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
    public interface IPersonRepository
    {
        bool VerifyUser(string email, string password);
    }
}
