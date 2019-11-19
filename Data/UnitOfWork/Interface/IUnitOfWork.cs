using System;
using System.Collections.Generic;
using System.Text;

namespace Data.UnitOfWork.Interface
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
