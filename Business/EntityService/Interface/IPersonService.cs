namespace Business.EntityService.Interface
{
    public interface IPersonService
    {
        void Verify(string email, string password);
    }
}
