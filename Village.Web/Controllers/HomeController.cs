using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Village.DataAccess.Repository;
using Village.Model;
using Village.Service;

namespace Village.Web.Controllers
{
    public class HomeController : Controller
    { 

        public ActionResult Index()
        {
            IPropertyRepository db = new PropertyRepository();
            PropertyService propertyservice = new PropertyService(db);
            var house = propertyservice.GetAllHouse();
            return View(house);
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