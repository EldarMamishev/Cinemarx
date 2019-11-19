using Domain.Repository;

namespace Data.UnitOfWork.Interface
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        IPersonRepository PersonRepository { get; }
    }
}
