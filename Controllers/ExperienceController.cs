using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
	public class ExperienceController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult ExperienceList()
		{
			var values = context.Experiences.ToList();//Experience tablosu listeleme
			return View(values);
		}
		//-------------------------------------------------------------------------------------------------------
		//Deneyim Tablosu Ekleme işlemi:

		[HttpGet]
		public IActionResult CreateExperience()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateExperience(Experience experience)
		{
			context.Experiences.Add(experience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
		//-----------------------------------------------------------------------------------------------------------
		//Deneyim Tablosu Silme İşlemi:
		public IActionResult DeleteExperience(int id)
		{
			var values = context.Experiences.Find(id);
			context.Experiences.Remove(values);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
		//-------------------------------------------------------------------------------------------------------------
		//Deneyim Tablosu Güncelleme işlemi:

		[HttpGet]
		public IActionResult UpdateExperience(int id)
		{
			var velues = context.Experiences.Find(id);
			return View(velues);
		}

		[HttpPost]
		public IActionResult UpdateExperience(Experience experience)
		{
			context.Experiences.Update(experience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");

		}
		//------------------------------------------------------------------------------------------------------------------------
	}
}
