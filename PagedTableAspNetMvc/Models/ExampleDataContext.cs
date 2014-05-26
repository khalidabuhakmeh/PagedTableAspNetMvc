using System;
using System.Data.Entity;

namespace PagedTableAspNetMvc.Models
{
    public class ExampleDataContext : DbContext
    {
        public IDbSet<Person> People { get; set; } 
    }

    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}