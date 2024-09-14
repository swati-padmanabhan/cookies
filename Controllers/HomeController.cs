using System;
using System.Web;
using System.Web.Mvc;
using CookiesDemo.Models;

namespace CookiesDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                //creates a new cookie named "Username"
                HttpCookie cookie = new HttpCookie("Username");

                //sets the cookie's value to the user's username
                cookie.Value = user.Username;

                //adds the cookie to the response
                HttpContext.Response.Cookies.Add(cookie);

                //sets the cookie expiration date to 2 days from now
                cookie.Expires = DateTime.Now.AddDays(2);

                return RedirectToAction("Index", "Welcome");
            }
            return View();
        }
    }
}