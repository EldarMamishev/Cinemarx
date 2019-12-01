using Business.EntityService.Interface;
using Business.Helper;
using Data.Repository;
using Data.UnitOfWork.Interface;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.EntityService
{
    class CinemaService : ICinemaService
    {
        private IUnitOfWork unitOfWork;

        public CinemaService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(string caption, string address, int? cinemaNetworkId, string city, string description, string email, string phoneNumber)
        {
            CinemaNetworkEntity network = this.unitOfWork.CinemaNetworkRepository.GetById(cinemaNetworkId ?? 0);

            CinemaEntity cinema = new CinemaEntity()
            {
                CinemaNetworkId = network.Id,
                Address = address,
                Caption = caption,
                Description = description,
                City = CityConverter.ConvertStringToEnum(city),
                Email = email,
                PhoneNumber = phoneNumber
            };

            this.unitOfWork.CinemaRepository.Add(cinema);
            this.unitOfWork.SaveChanges();
        }

        public void Update(int id, string caption, string address, int? cinemaNetworkId, string city, string description, string email, string phoneNumber)
        {
            CinemaEntity cinema = this.unitOfWork.CinemaRepository.GetById(id);
            CinemaNetworkEntity network = this.unitOfWork.CinemaNetworkRepository.GetById(cinemaNetworkId ?? 0);

            cinema.CinemaNetworkId = network.Id;
            cinema.Address = address;
            cinema.Caption = caption;
            cinema.Description = description;
            cinema.City = CityConverter.ConvertStringToEnum(city);
            cinema.Email = email;
            cinema.PhoneNumber = phoneNumber;

            this.unitOfWork.CinemaRepository.Update(cinema);
            this.unitOfWork.SaveChanges();
        }
    }
}
