using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebSystem.Controllers
{
    public class CrudUserController : Controller
    {
       
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Username, string Password)
        {
            var user = new CrudUsuario();

            var auxUser = new UserDTO
            {
                Username = Username,
                Password = Password
            };


            return View();
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(string Username, string Password)
        {
            var user = new CrudUsuario();




        }

        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(string Username, string Password)
        {
            var user = new CrudUsuario();




        }

        [HttpGet]
        public ActionResult Read()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Read(string Username, string Password)
        {
            var user = new CrudUsuario();




        }

    }
}