using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PagedTableAspNetMvc.Models
{
    public class EditModel
    {
        public EditModel()
        {

        }

        public EditModel(Person person)
        {
            Id = person.Id;
            FullName = person.FullName;
            Phone = person.Phone;
            Email = person.Email;
        }

        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }

        public Person ToPerson(Person person = null)
        {
            person = person ?? new Person();

            person.FullName = FullName;
            person.Email = Email;
            person.Phone = Phone;

            return person;
        }
    }
}