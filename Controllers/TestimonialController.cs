using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
	public class TestimonialController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()//listeleme İşlemi
		{
			var values=context.Testimonials.ToList();
			return View(values);
		}
		//-----------------------------------------------------------------------------------------
		[HttpGet]
		public IActionResult CreateTestimonial()//Ekleme işlemi
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateTestimonial(Testimonial testimonial)
		{
			context.Testimonials.Add(testimonial);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		//----------------------------------------------------------------------------------------
		public IActionResult DeleteTestimonial(int id)//Silme İŞlemi
		{
			var values = context.Testimonials.Find(id);
			context.Testimonials.Remove(values);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		//---------------------------------------------------------------------------------------
		[HttpGet]
		public IActionResult UpdateTestimonial(int id)//Güncelleme İŞlemi
		{
			var values = context.Testimonials.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			context.Testimonials.Update(testimonial);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		//---------------------------------------------------------------------------------------
	}
}
