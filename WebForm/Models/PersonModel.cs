using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebForm.Models
{
    public class PersonModel
    {
        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Gender { get; set; }
        [StringLength(11)]
        public string ContactNo { get; set; }
        
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
