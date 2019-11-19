using Data.UnitOfWork.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private CinemarxContext dbContext;

        public void SaveChanges() => this.dbContext.SaveChanges();

        public UnitOfWork(CinemarxContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
