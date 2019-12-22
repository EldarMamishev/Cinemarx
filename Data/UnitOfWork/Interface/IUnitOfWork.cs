using Domain.Repository;

namespace Data.UnitOfWork.Interface
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        IPersonRepository PersonRepository { get; }
        ICinemaRepository CinemaRepository { get; }
        ICinemaNetworkRepository CinemaNetworkRepository { get; }
        IFilmRepository FilmRepository { get; }
    }
}
