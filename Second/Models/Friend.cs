using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Second.Models
{
    public class Friend
    {
        [Required]
        public int FriendID {get; set;}
        [MinLength(1, ErrorMessage = "Friend Name Empty Not Allowed")]
        public string FriendName { get; set;}
        [StringLength(50, ErrorMessage = "The leng of the Place shouldn't be more than 25 characters")]
        public string Place { get; set;}
    }
}