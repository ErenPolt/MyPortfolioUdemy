using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
	public class SkillController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()//Skill Tablosu listeleme
		{
			var values=context.Skills.ToList();
			return View(values);
		}
		//------------------------------------------------------------------
		public IActionResult DeleteSkill(int id)
		{
			var values = context.Skills.Find(id);//Silme İşlemi
			context.Skills.Remove(values);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		//------------------------------------------------------------------------
		[HttpGet]
		public IActionResult CreateSkill()//Ekleme işlemi
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateSkill(Skill skill)
		{
			context.Skills.Add(skill);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		//----------------------------------------------------------------------------
		[HttpGet]
		public IActionResult UpdateSkill(int id)
		{
			var values = context.Skills.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateSkill(Skill skill)
		{
			context.Skills.Update(skill);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
