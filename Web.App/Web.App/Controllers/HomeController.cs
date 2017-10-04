using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Data.Repositories;
namespace Web.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebDbContext ct = new WebDbContext();
        public ActionResult Index()
        {
            ct.Pessoas.Find(1);
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