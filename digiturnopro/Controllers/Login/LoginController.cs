using Data.Usuarios;
using Data.Utilidades;
using Entities.Usuarios;
using Negocio.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using static System.Net.WebRequestMethods;

namespace digiturnopro.Controllers.Login
{
    public class LoginController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UsuarioModel model) {
            try {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                Usuario usuario = UsuarioData.getUsuarioPorNombreUsuarioYContrasena(model.Nombreusuario,model.Contrasena);
                if (usuario!=null)
                {
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,model.Nombreusuario,DateTime.Now,DateTime.Now.AddMinutes(60),true, "",FormsAuthentication.FormsCookiePath);
                    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket)) {
                        HttpOnly = true,
                    };
                    Response.Cookies.Add(cookie);
                    string returnUrl = Request.QueryString["ReturnUrl"];
                    if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(Url.Action("Index", "Home"));
                    }
                    return Redirect(returnUrl);
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

        [HttpGet]
        public ActionResult CrearCuenta() {            
            return View();
        }

        [HttpPost]
        public ActionResult CrearCuenta(UsuarioModel usuario) {
            try
            {
                var usuarioRegistrado = UsuarioNegocioModel.VerificarCreacionUsuario(usuario);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.mensaje = ex.Message;
                return View();
            }
            finally
            {
                Connection.closeConnection();
            }
        }
    }
}