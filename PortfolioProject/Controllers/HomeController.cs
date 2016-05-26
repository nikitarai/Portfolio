using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProject.Models;


namespace PortfolioProject.Controllers
{
    public class HomeController : Controller
    {
        private PortfolioWebsiteEntities1 db = new PortfolioWebsiteEntities1();

        public ActionResult Index()
        {

            return View(db.Portfolios.ToList());
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