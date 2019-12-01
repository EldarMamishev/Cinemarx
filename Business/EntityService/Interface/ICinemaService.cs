using System;
using System.Collections.Generic;
using System.Text;

namespace Business.EntityService.Interface
{
    public interface ICinemaService
    {
        void Add(string caption, string address, int? cinemaNetworkId, string city, string description, string email, string phoneNumber);
        void Update(int id, string caption, string address, int? cinemaNetworkId, string city, string description, string email, string phoneNumber);
    }
}
