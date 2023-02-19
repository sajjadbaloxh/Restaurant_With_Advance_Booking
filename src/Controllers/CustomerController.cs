using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using Restaurant_Advance_Booking.Data;
using RestaurantAdvanceBooking.Models;

namespace Restaurant_Advance_Booking.Controllers
{
 
   
    public class CustomerController : Controller
    {
        ResturantDbContext _context;

        public CustomerController(ResturantDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
     
        }

        [HttpPost]
        public IActionResult CustomerLogin(Customer cs)
        {
            var c = _context.customers.FirstOrDefault(f => f.Email == cs.Email && f.Password == cs.Password);
            return RedirectToAction("CustomerDashboard");

        }

        // Get Method 
        public IActionResult CustomerLogin() { 


              return View();

    }

    /// / Get Method
    public ActionResult CustomerSignup()
        {
            
            return View();

        }

        [HttpPost]
        public IActionResult CustomerSignup(Customer cs)
        {
            _context.customers.Add(cs);
            _context.SaveChanges();
            return RedirectToAction("CustomerLogin");
        }
        // Customer DashBoard

        public ActionResult CustomerDashboard()
        {

            return View();

        }

       
        // table reserve Customer
        [HttpPost]
        public IActionResult TableReserveCustomer(Table_Reservation Tb)
        {
            List<Table_Reservation> li = _context.Table_Reservations.ToList();
            Tb.status = "Pending";
            _context.Table_Reservations.Add(Tb);
            _context.SaveChanges();
            return View("ShowStatus",li);
        }

        // status chek in Customer
        public IActionResult ShowStatus()
        {
            List<Table_Reservation> li = _context.Table_Reservations.ToList();
            return View(li);
        }
    }
}
