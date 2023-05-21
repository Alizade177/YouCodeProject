using Microsoft.AspNetCore.Mvc;
using YouCode.Models.Context;
using YouCode.Models.Entity;

namespace YouCode.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Contact contact) 
        {
            contact.MessageDate = DateTime.Now; 
            YouCodeContext context = new YouCodeContext();  
            context.Contacts.Add(contact);  
            context.SaveChanges();
            if (context.SaveChanges() > 0)
            {
                TempData["isSuccess"] = "Mesaj ugurla gonderildi!";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["isSuccess"] = "Mesaj gonderile bilmedi!";
                return RedirectToAction("Index");
            }
            
        }
    }
}
