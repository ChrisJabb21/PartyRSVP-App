using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyRSVP2.Models;

namespace PartyRSVP2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index () {
            return View("Rsvp");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Info and Event Address";

            return View();
        }



        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            // Todo: Store guest response, covered in later lessons
            return View("Thanks", guestResponse);
        }
        /*
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
         */
    }

}
