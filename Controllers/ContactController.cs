using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()//Listeleme
        {
            var values=context.Contacts.ToList();
            return View(values);
        }
        //--------------------------------------------------------------------------
        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var values = context.Contacts.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
