using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebForm.Models
{
    public class PersonModel
    {
        [Key]
        public int ID { get; set; }


        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Last Name Invalid"), Required, StringLength(20)]
        public string LastName { get; set; }

        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "First Name Invalid"), Required, StringLength(20)]
        public string FirstName { get; set; }


        [RegularExpression(@"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$", ErrorMessage = "Gender Invalid"), Required, StringLength(6)]
        public string Gender { get; set; }

        [StringLength(11), Required]
        public string ContactNo { get; set; }
        
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email"), Required]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        public string Password { get; set; }
    }
}
