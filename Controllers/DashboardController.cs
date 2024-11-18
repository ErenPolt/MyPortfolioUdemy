using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Controllers
{
	public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
