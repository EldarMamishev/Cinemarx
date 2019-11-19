using Data.Repository;
using Data.UnitOfWork.Interface;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private CinemarxContext dbContext;
        private IPersonRepository personRepository;

        public IPersonRepository PersonRepository 
        { 
            get
            {
                if (this.personRepository == null)
                    this.personRepository = new PersonRepository(this.dbContext);

                return this.personRepository;
            }
        }

        public void SaveChanges() => this.dbContext.SaveChanges();

        public UnitOfWork(CinemarxContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
