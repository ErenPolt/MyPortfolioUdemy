using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
	public class ToDoListController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()//Listeleme İşlemi
		{
			var values= context.ToDoLists.ToList();
			return View(values);
		}
		//---------------------------------------------------------------------
		[HttpGet]
		public IActionResult CreateToDoList()//Ekleme İşlemi
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateToDoList(ToDoList toDoList)
		{
			toDoList.Status = false;
			context.ToDoLists.Add(toDoList);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		//-------------------------------------------------------------------------------
		public IActionResult DeleteToDoList(int id)//Silme İşlemi
		{
			var values = context.ToDoLists.Find(id);
			context.ToDoLists.Remove(values);
			context.SaveChanges();
			return RedirectToAction("Index");

		}
		//-----------------------------------------------------------------------------------------
		[HttpGet]
		public IActionResult UpdateToDoList(int id)//Güncelleme İŞlemi
		{
			var values = context.ToDoLists.Find(id);
			return View(values);
		}

		[HttpPost]
		public IActionResult UpdateToDoList(ToDoList toDoList)
		{
			var values=context.ToDoLists.Update(toDoList);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		//--------------------------------------------------------------------------
		public IActionResult ChangeToDoListStatusToTrue(int id)//Durum True olsun
		{
			var values = context.ToDoLists.Find(id);
			values.Status= true;
			context.SaveChanges();
			return RedirectToAction("Index");

		}
		//---------------------------------------------------------------------------
		public IActionResult ChangeToDoListStatusToFalse(int id)//Durum False Olsun..
		{
			var values=context.ToDoLists.Find(id);
			values.Status= false;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		//----------------------------------------------------------------------------
	}
}
