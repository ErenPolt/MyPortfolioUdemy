using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using System.Diagnostics.Metrics;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Portfolios.Count();
            ViewBag.v4 = context.Experiences.Count();
            //ViewBag.v3 = contex.Messages.Where(x => x.IsRead == true).Count();
            //ViewBag.v4 = contex.Messages.Where(x => x.IsRead == false).Count();
            return View();
        }
    }
}
