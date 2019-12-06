using Business.EntityService.Interface;
using Data.UnitOfWork.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.ViewModel.Film;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : Controller
    {
        private IUnitOfWork unitOfWork;
        private IFilmService filmService;

        public FilmController(IUnitOfWork unitOfWork, IFilmService filmService)
        {
            this.unitOfWork = unitOfWork;
            this.filmService = filmService;
        }

        [HttpPost]
        [Route("/create")]
        public ActionResult CreateCinema([FromBody] CreateFilmRequest film)
        {
            if (!ActiveStatus.ActiveUser.IsAdmin)
                return this.BadRequest();

            try
            {
                this.filmService.Add(film.Caption, film.Duration, film.AgeRate, film.Premiere);
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }

            return this.Ok(film);
        }

        [HttpPost]
        [Route("/update")]
        public ActionResult Update([FromBody] UpdateFilmRequest film)
        {
            if (!ActiveStatus.ActiveUser.IsAdmin)
                return this.BadRequest();

            try
            {
                this.filmService.Update(film.Id, film.Caption, film.Duration, film.AgeRate, film.Premiere);
            }
            catch (ArgumentException exception)
            {
                return this.NotFound(exception.Message);
            }
            catch (Exception exception)
            {
                return this.BadRequest(exception.Message);
            }

            return this.Ok(film);
        }
    }
}
