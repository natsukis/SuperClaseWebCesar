using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSystem.Controllers
{
    public class NewsController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Creacion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Creacion()
        {
            return View();
        }


    }
}
