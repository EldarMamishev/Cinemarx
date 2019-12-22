using Domain.Entity;
using Domain.Repository.Base;

namespace Domain.Repository
{
    public interface IPersonRepository : IEntityRepository<PersonEntity>
    {
        bool VerifyUser(string email, string password);
    }
}
