using Data.UnitOfWork.Interface;
using System;

namespace Business.EntityService
{
    public sealed class PersonService
    {
        private IUnitOfWork unitOfWork;
        public void Verify(string email, string password)
        {
            if (!this.unitOfWork.PersonRepository.VerifyUser(email, password))
                throw new ArgumentException("User undefined.");
        }

        public PersonService (IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
