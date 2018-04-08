using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReadWayInternationCollege.Models
{
    public class SendAMessageViewModel
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter your email address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage ="Please enter a subject")]
        public string Subject { get; set; }


        [Required(ErrorMessage ="Please enter a message")]
        public string Message { get; set; }
    }
}