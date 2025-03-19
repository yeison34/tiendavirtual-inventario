using Data.Utilidades;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace digiturnopro.Controllers
{
    public class HomeController : Controller
    {
        [FiltroWeb(ValidarAction = true, Registrado = true, Autorizado = true, Requiereinformacionpersonal=true)]
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated) {
                var stringname = User.Identity.GetUserId();
            }
            return View();
        }
        //[FiltroWeb(ValidarAction=true, Registrado=true, Autorizado=true)]
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