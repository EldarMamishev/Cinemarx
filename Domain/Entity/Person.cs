using Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Domain.Entity
{
    public class PersonEntity : EntityBase
    {
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public virtual ICollection<TicketEntity> Tickets { get; set; }
        public bool IsAdmin { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            string pattern = @"^\w{1, 10}([\-\`\'\s])?\w{2, 15}$";
            string antiPattern = @"\d";

            if (!Regex.IsMatch(this.Name, pattern) || Regex.IsMatch(this.Name, antiPattern))
                yield return new ValidationResult(nameof(Name));

            if (!Regex.IsMatch(this.Surname, pattern) || Regex.IsMatch(this.Name, antiPattern))
                yield return new ValidationResult(nameof(Surname));

        }
    }
}
