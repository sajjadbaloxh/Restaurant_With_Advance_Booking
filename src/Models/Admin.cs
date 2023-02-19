using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAdvanceBooking.Models
{
    public class Admin
    {
        [Key]
        public int Admin_Id { get; set; }
     
        public string Email { get; set; }
        public string Password { get; set; }
      
    }
}



     