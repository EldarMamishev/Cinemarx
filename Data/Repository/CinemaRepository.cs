using Data.Repository.Base;
using Domain.Entity;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class CinemaRepository : EntityRepository<CinemaEntity>, ICinemaRepository
    {
        public CinemaRepository(DbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
