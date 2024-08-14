using Entities.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace digiturnopro.Controllers.Login
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model) {
            try {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                if (model.UserName == "123" && model.Password == "12345678")
                {
                    return RedirectToAction("Index", "Home");
                }
                else {
                    ViewBag.mensaje = "Usuario o Contraseña Incorrecta";
                }
            }
            catch (Exception ex) {
                throw;
            }
            return View(model);
        }
    }
}