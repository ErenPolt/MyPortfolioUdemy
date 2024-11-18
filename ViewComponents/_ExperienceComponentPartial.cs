using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext contex=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=contex.Experiences.ToList();
            return View(values);
        }
    }
}
