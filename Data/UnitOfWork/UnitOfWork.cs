using Data.Repository;
using Data.UnitOfWork.Interface;
using Domain.Repository;

namespace Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private CinemarxContext dbContext;
        private ICinemaRepository cinemaRepository;
        private IPersonRepository personRepository;
        private ICinemaNetworkRepository cinemaNetworkRepository;
        private IFilmRepository filmRepository;

        public IPersonRepository PersonRepository 
        { 
            get
            {
                if (this.personRepository == null)
                    this.personRepository = new PersonRepository(this.dbContext);

                return this.personRepository;
            }
        }

        public ICinemaRepository CinemaRepository
        {
            get
            {
                if (this.cinemaRepository == null)
                    this.cinemaRepository = new CinemaRepository(this.dbContext);

                return this.cinemaRepository;
            }
        }

        public ICinemaNetworkRepository CinemaNetworkRepository
        {
            get
            {
                if (this.cinemaNetworkRepository == null)
                    this.cinemaNetworkRepository = new CinemaNetworkRepository(this.dbContext);

                return this.cinemaNetworkRepository;
            }
        }

        public IFilmRepository FilmRepository
        {
            get
            {
                if (this.filmRepository == null)
                    this.filmRepository = new FilmRepository(this.dbContext);

                return this.filmRepository;
            }
        }

        public void SaveChanges() => this.dbContext.SaveChanges();

        public UnitOfWork(CinemarxContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
