using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using Task2.Models;


namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveData(string value, DateTime expirationDate)
        {
            CookieOptions options = new CookieOptions();
            options.Expires = expirationDate;
            Response.Cookies.Append("Value", value);
            


            return RedirectToAction("Index");
        }
        public IActionResult Check()
        {
            if (Request.Cookies["Value"] != null)
            {
                string value = Request.Cookies["Value"];
                return Content($"Cookie exists with value: {value}");
            }
            else
            {
                return Content("Cookie does not exist");
            }
        }
    }
}
