using System;
using Business.EntityService.Interface;
using Data.UnitOfWork.Interface;
using Microsoft.AspNetCore.Mvc;
using ViewModel.ViewModel.Person;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : Controller
    {
        private IUnitOfWork unitOfWork;
        private IPersonService personService;

        [HttpPost]
        [Route("")]
        public ActionResult Verify([FromBody] UserAccountViewModel userAccount)
        {
            try
            {
                this.personService.Verify(userAccount.Email, userAccount.Password);
            }
            catch (ArgumentException)
            {
                this.NotFound();
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }

            return this.Ok(userAccount);
        }

        public RegistrationController(IUnitOfWork unitOfWork, IPersonService personService)
        {
            this.unitOfWork = unitOfWork;
            this.personService = personService;
        }
    }
}