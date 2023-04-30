using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Second.Models
{
    public class Friend
    {
      /*  public Friend(int friendID, string friendName, string place)
        {
            FriendID = friendID;
            FriendName = friendName;
            Place = place;
        }
      */
        [Required]
        public int FriendID { get; set; }
        [MinLength(1, ErrorMessage = "Friend Name Empty Not Allowed")]
        public string FriendName { get; set; }
        [StringLength(50, ErrorMessage = "The leng of the Place shouldn't be more than 25 characters")]
        public string Place { get; set; }

    }
}