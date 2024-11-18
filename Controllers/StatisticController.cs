using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext contex = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = contex.Skills.Count();
			ViewBag.v2 = contex.Skills.Select(x => x.Value).Max(); //En yüksek değere sahip yetenek değeri
			ViewBag.v3 = contex.Skills.Select(x => x.Value).Min();//En düşük değere sahip yetenek değeri
			ViewBag.v4 = contex.Skills.Select(x => x.Value).Average();//Yetenek Değerlerinin ortalaması
			ViewBag.v5 = contex.Messages.Count();
			ViewBag.v6 = contex.Messages.Where(x => x.IsRead == true).Count();//Okunmuş Mesaj Sayısı
			ViewBag.v7 = contex.Messages.Where(x => x.IsRead == false).Count();//Okunmamış Mesaj Sayısı
			ViewBag.v8 = contex.ToDoLists.Count();//Yapılacakların sayısı
			ViewBag.v9 = contex.ToDoLists.Where(x=>x.Status==true).Count();//Yapılacaklar Listesinde yapılmış olanlar
			ViewBag.v10 = contex.ToDoLists.Where(x=>x.Status==false).Count();//Yapılacaklar Listesinde yapılmamış olanlar
			ViewBag.v11 = contex.Experiences.Count();//Deneyimler sayısı
			ViewBag.v12 = contex.Abouts.Count();//Hakkımda sayısı
			ViewBag.v13 = contex.Portfolios.Count();//Proje sayısı
			ViewBag.v14 = contex.Portfolios.Where(x => x.PortfolioId == 9).Select(y => y.Title).FirstOrDefault();//Son projem
			ViewBag.v15 = contex.Portfolios.Where(x => x.PortfolioId == 6).Select(y => y.Title).FirstOrDefault();//En Zor Projem
			ViewBag.v16 = contex.Portfolios.Where(x => x.PortfolioId == 4).Select(y => y.Title).FirstOrDefault();//ilk Projem
			ViewBag.v17 = contex.Portfolios.Where(x => x.PortfolioId == 9).Select(y => y.Title).FirstOrDefault();//En Sevdiğim projem
			ViewBag.v18 = contex.Testimonials.Count();//Referans SAyısı
			ViewBag.v19 = contex.SocialMedias.Count();//Referans SAyısı
			ViewBag.v20 = contex.SocialMedias.Where(x => x.SocialMediaId == 2).Select(y => y.Title).FirstOrDefault();//Referans SAyısı
			return View();
		}
	}
}
