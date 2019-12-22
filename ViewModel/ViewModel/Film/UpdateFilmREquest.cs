using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.ViewModel.Film
{
    public class UpdateFilmRequest
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public int Duration { get; set; }
        public int AgeRate { get; set; }
        public DateTime Premiere { get; set; }
    }
}
