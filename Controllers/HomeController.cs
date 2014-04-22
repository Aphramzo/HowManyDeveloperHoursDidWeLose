using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HowManyDeveloperHoursDidWeLose.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			//ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
			var hours = 5* (DateTime.Now.Subtract(DateTime.Parse("2014/04/22 12:00 PM"))).TotalHours;
			ViewBag.Hours = hours;
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
