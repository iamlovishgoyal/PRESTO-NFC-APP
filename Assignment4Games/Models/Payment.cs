using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment4Games.Models
{
    public class Payment



    {
        [Key]
        public int prestono { get; set; }

        public int Amount { get; set; }

        [Required(ErrorMessage = "Please choose the pass")]
        public int Pass { get; set; }



        [Required]
        public string name
        {
            get;
            set;
        }

        [Required(ErrorMessage = "email is required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
            ErrorMessage = "Please enter proper email")]
        public string email
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Mobile is required")]
        [RegularExpression(@"\d{10}", ErrorMessage = "Please enter 10 digit Mobile No.")]
        public string mobile
        {
            get;
            set;
        }

        public int Card { get; set; }
        public int CVV { get; set; }
        public DateTimeKind Date { get; set; } 

       

    //[Required(ErrorMessage = "Password is required")]
    //[DataType(DataType.Password)]
    //public string Password
    //{
    //    get;
    //    set;
    //}

    //[Required(ErrorMessage = "Confirm Password is required")]
    //[DataType(DataType.Password)]
    //[Compare("Password")]
    //public string ConfirmPassword
    //{
    //    get;
    //    set;
    //}

    [Required(ErrorMessage = "Age is required")]
        [Range(typeof(int), "18", "40", ErrorMessage = "Age can only be between 18 and 40")]
        public string age
        {
            get;
            set;
        }
    }
}
