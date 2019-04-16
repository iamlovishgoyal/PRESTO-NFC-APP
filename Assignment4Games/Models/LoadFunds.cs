using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4Games.Models
{
    public class LoadFunds
    {
        //[Key]
        //public string PrestoNumber { get; set; }


        //[MaxLength(3, ErrorMessage = "Please enter less than $1000")]
        //[MinLength(2, ErrorMessage = "Please add more than $10")]
       // [RegularExpression("^[0-9]*$", ErrorMessage = "Amount must be in numerics")]
        //[MaxLength(3, ErrorMessage ="Please enter less than $1000")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Please choose the pass")]
        public int Pass { get; set; }


        
        

        //public string Genre { get; set; }

        //public string Developer { get; set; }

        //public string Platform { get; set; }

        //public string Languages { get; set; }

        //public int Rating { get; set; }

        //public string Description { get; set; }
    }
}
