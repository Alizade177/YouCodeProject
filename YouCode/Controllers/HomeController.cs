using Microsoft.AspNetCore.Mvc;
using YouCode.Models.Context;
using YouCode.Models.Entity;

namespace YouCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
   
            return View();
        }
    }
}
