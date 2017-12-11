using Servicios;
using Servicios.Model;
using Servicios.Operaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSystem.Controllers
{
    public class SesionController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(string Username, string Password)
        {
            var user = new CrudUsuario();

            
                     
            if (user.Read(Username, Password) == null)
            {
                return RedirectToAction("Login","Sesion");
            }
            else
            {
                return View();
            }

           
        }

    }
}