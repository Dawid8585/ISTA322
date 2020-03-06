using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //return "Hello MSSA ";
            int hour = DateTime.Now.Hour;

            //string greeting;
            //if (hour < 12)
            //    greeting = "good morning";
            //else if (hour < 16)
            //    greeting = " good afternoon";
            //else
            //    greeting = "good evening";

            ViewBag.Greeting = (hour < 12) ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }

    }
}
