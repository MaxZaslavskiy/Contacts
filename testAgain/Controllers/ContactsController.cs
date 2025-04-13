using testAgain.Models;
using Microsoft.AspNetCore.Mvc;

namespace testAgain.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()  // contacts
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Feedback feedback) 
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }

            return View("Index");
        }
    }
}
