using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
	public class SocialMediaController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();	
		public IActionResult Index()//SosyalMedya listeleme
		{
			var values=context.SocialMedias.ToList();
			return View(values);
		}
		//----------------------------------------------------------------------------
		[HttpGet]
		public IActionResult CreateSocialMedia()//SosyalMedya Ekleme
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateSocialMedia(SocialMedia socialMedia)
		{
			context.SocialMedias.Add(socialMedia);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		//-------------------------------------------------------------------------------
		public IActionResult DeleteSocialMedia(int id)//SosyalMedya Silme
		{
			var value = context.SocialMedias.Find(id);
			context.SocialMedias.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		//--------------------------------------------------------------------------------------
		[HttpGet]
		public IActionResult UpdateSocialMedia(int id)//SosyalMedya Güncelleme
		{
			var values = context.SocialMedias.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
		{
			context.SocialMedias.Update(socialMedia);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		//-----------------------------------------------------------------------------------
	}
}
