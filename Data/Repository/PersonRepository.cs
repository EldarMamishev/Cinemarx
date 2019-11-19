using Data.Repository.Base;
using Domain.Entity;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class PersonRepository : EntityRepository<PersonEntity>, IPersonRepository
    {
        public PersonRepository(DbContext dbContext) 
            : base(dbContext)
        {
        }

        public bool VerifyUser(string email, string password)            
            => this.dbContext.Set<PersonEntity>().FirstOrDefault(p => p.Email == email && p.Password == password) != null;
    }
}
