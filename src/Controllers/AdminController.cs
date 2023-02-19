using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant_Advance_Booking.Data;
using RestaurantAdvanceBooking.Models;

namespace RestaurantAdvanceBooking.Controllers
{
    public class AdminController : Controller
    {
        ResturantDbContext _context;

        public AdminController(ResturantDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(Admin Ad)
        {
            var c = _context.Admins.FirstOrDefault(a => a.Email == Ad.Email && a.Password == Ad.Password);
            return RedirectToAction("AdminShowList");

        }

        public IActionResult AdminLogin()
        {
            return View();

        }

        public IActionResult AdminShowList()
        {
            List<Table_Reservation> res = _context.Table_Reservations.ToList();

            return  View(res);
        }
        // Accept Request
        public IActionResult RequestApproval(int Reservation_Id)
        {
            var c = _context.Table_Reservations.FirstOrDefault(x=> x.Reservation_Id== Reservation_Id);

            c.status = "Approved";

            _context.SaveChanges();

            List<Table_Reservation> res = _context.Table_Reservations.ToList();

            return View("AdminShowList",res);
        }
        // REJECT request 


        public IActionResult RequestReject(int Reservation_Id)
        {
            var c = _context.Table_Reservations.FirstOrDefault(x => x.Reservation_Id == Reservation_Id);

            c.status = "Reject";

            _context.SaveChanges();

            List<Table_Reservation> res = _context.Table_Reservations.ToList();

            return View("AdminShowList", res);
        }

    }
}
