using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Person
    {
        public Person()
        {
            List<Role> roles = new List<Role>();
        }
        [Key]
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

    }
}
