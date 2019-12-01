using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.ViewModel.Cinema
{
    public class UpdateCinemaRequest
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string Address { get; set; }
        public int? CinemaNetworkId { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
