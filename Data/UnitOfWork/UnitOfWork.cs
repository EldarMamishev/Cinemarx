using System;
using System.Collections.Generic;
using System.Text;

namespace Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public void SaveChanges() => this.dbContext.SaveChanges();

        public UnitOfWork(FamilyWalletContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
