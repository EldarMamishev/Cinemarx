﻿using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entity;
using Domain.Repository.Base;

namespace Domain.Repository
{
    public interface IFilmRepository : IEntityRepository<FilmEntity>
    {
    }
}
