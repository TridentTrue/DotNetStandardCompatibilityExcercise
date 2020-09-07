using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompatibilityExcercise.Standard;

namespace CompatibilityExcercise.Framework.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			int number = new StandardClassThing(30, 12).Calculate();
			ViewBag.Calc = number;
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}