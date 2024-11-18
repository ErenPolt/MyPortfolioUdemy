using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()//Hakkımda Tablosu listeleme işlemi
        {
            var values=context.Abouts.ToList();
            return View(values);
        }
        //------------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = context.Abouts.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
