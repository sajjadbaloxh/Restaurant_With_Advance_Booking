using System.ComponentModel.DataAnnotations;

namespace RestaurantAdvanceBooking.Models
{
    public class Customer
    {
        [Key]
        public int User_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
