namespace Domain.Repository
{
    public interface IPersonRepository
    {
        bool VerifyUser(string email, string password);
    }
}
