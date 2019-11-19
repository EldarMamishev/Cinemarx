using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.EntityService;
using Data.UnitOfWork.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModel.ViewModel.Person;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private IUnitOfWork unitOfWork;
        private PersonService personService;

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

        public RegistrationController(IUnitOfWork unitOfWork, PersonService personService)
        {
            this.unitOfWork = unitOfWork;
            this.personService = personService;
        }
    }
}