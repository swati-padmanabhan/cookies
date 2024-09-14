using System.Web;
using System.Web.Mvc;

namespace CookiesDemo.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult Index()
        {
            HttpCookie cookie = Request.Cookies["Username"];
            if (cookie != null)
            {
                ViewBag.Message = Request.Cookies["Username"].Value.ToString();
            }
            else
            {
                RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}