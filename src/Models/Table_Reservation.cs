using System.ComponentModel.DataAnnotations;

namespace RestaurantAdvanceBooking.Models
{
    public class Table_Reservation
    {
        [Key]
        public int Reservation_Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Number_of_persons { get; set; }
        public DateTime DateTime { get; set; }
       
        public string Special_Request { get; set; }
        public string status { get; set; }
    }
}
