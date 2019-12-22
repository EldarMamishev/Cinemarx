using Data.Repository.Base;
using Domain.Entity;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class FilmRepository : EntityRepository<FilmEntity>, IFilmRepository
    {
        public FilmRepository(DbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
