using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReadWayInternationCollege.Models
{
    public class SendAMessageViewModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Your name must consist only of alphabets")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter the subject of your message")]
        public string Subject { get; set; }


        [Required(ErrorMessage = "Please enter your message")]
        public string Message { get; set; }
    }
}