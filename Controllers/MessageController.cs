using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Inbox()//Mesaj Tablosu Listeleme
		{
			var values=context.Messages.ToList();
			return View(values);
		}
		//-------------------------------------------------------------------
		//Mesaj Durumları Değiştirme:

		public IActionResult ChangeIsReadToTrue(int id)//Durumu Okundu olarak işaretle
		{
			var value = context.Messages.Find(id);
			value.IsRead = true;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult ChangeIsReadToFalse(int id)//Durumu Okunmadı olarak işaretle
		{
			var value = context.Messages.Find(id);
			value.IsRead = false;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		//----------------------------------------------------------------------------------
		//Mesaj Silme İşlemi:
		public IActionResult DeleteMessage(int id)
		{
			var value = context.Messages.Find(id);
			context.Messages.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		//-----------------------------------------------------------------------------------------------
		//Mesajı Gösterme:
		public IActionResult MessageDetail(int id)
		{
			var values = context.Messages.Find(id);
			return View(values);
		}
	}
}
