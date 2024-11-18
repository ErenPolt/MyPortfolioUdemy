using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext contex=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = contex.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = contex.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetails = contex.Abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}
