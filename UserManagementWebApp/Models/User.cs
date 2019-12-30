using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagementWebApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [DisplayName("Username")]
        [Required]
        [Column(TypeName = "VARCHAR(250)")]
        public string Username { get; set; }

        [DisplayName("Password")]
        [Required]
        [Column(TypeName = "VARCHAR(250)")]
        public string Password { get; set; }

        [DisplayName("First name")]
        [Required]
        [Column(TypeName = "VARCHAR(250)")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        [Required]
        [Column(TypeName = "VARCHAR(250)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(10)")]
        public string Sex { get; set; }
        
        [DisplayName("Birth date")]
        [Required]
        public DateTime BirthDate { get; set; }

        [Column(TypeName = "VARCHAR(250)")]
        public string Description { get; set; }

        public DateTime RegistrationDate { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> Sexes { get; set; }
    }
}
