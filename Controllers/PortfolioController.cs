using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class PortfolioController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()//Listeleme işlemi
        {
            var values=context.Portfolios.ToList();
            return View(values);
        }
        //----------------------------------------------------------------------
        [HttpGet]
        public IActionResult CreatePortfolio()//Ekleme işlemi
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        //----------------------------------------------------------------
        public IActionResult DeletePortfolio(int id)//Silme İşlemi
        {
            var values = context.Portfolios.Find(id);
            context.Portfolios.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        //---------------------------------------------------------------------
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)//Güncelleme İşlemi
        {
            var values= context.Portfolios.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Update(portfolio);
            return RedirectToAction("Index");
        }
        //-----------------------------------------------------------------------
    }
}
