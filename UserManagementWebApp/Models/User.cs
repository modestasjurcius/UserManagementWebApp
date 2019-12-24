using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagementWebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> Sexes { get; set; }
    }
}
