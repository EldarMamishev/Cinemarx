using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.EntityService.Interface;
using API;
using Data.UnitOfWork.Interface;
using Microsoft.AspNetCore.Mvc;
using ViewModel.ViewModel.Cinema;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : Controller
    {
        private IUnitOfWork unitOfWork;
        private ICinemaService cinemaService;

        public CinemaController(IUnitOfWork unitOfWork, ICinemaService cinemaService)
        {
            this.unitOfWork = unitOfWork;
            this.cinemaService = cinemaService;
        }

        [HttpPost]
        [Route("create")]
        public ActionResult CreateCinema([FromBody] CreateCinemaRequest cinema)
        {
            //if (!ActiveStatus.ActiveUser.IsAdmin)
            //    return this.BadRequest();

            try
            {
                this.cinemaService.Add(cinema.Caption, cinema.Address, cinema.CinemaNetworkId, cinema.City, cinema.Description, cinema.Email, cinema.PhoneNumber);
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }

            return this.Ok(cinema);
        }

        [HttpPost]
        [Route("/update")]
        public ActionResult Update([FromBody] UpdateCinemaRequest cinema)
        {
            //if (!ActiveStatus.ActiveUser.IsAdmin)
            //    return this.BadRequest();

            try
            {
                this.cinemaService.Update(cinema.Id, cinema.Caption, cinema.Address, cinema.CinemaNetworkId, cinema.City, cinema.Description, cinema.Email, cinema.PhoneNumber);
            }
            catch (ArgumentException exception)
            {
                return this.NotFound(exception.Message);
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }

            return this.Ok(cinema);
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<CinemaViewModel> Get() => this.unitOfWork.CinemaRepository.GetAll()
            .Select(f => new CinemaViewModel() { Id = f.Id, Caption = f.Caption, Description = f.Description, Address = f.Address});
    }
}