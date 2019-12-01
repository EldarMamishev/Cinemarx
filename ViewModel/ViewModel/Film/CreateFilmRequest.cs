using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel.ViewModel.Film
{
    public class CreateFilmRequest
    {
        public string Caption { get; set; }
        public int Duration { get; set; }
        public int AgeRate { get; set; }
        public DateTime Premiere { get; set; }
    }
}
