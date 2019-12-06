using Data.Repository.Base;
using Domain.Entity;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class CinemaNetworkRepository : EntityRepository<CinemaNetworkEntity>, ICinemaNetworkRepository
    {
        public CinemaNetworkRepository(DbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
