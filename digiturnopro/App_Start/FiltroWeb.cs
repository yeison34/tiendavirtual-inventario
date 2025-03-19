using Data.Usuarios;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Web.Routing;

namespace digiturnopro
{
    public class FiltroWeb : ActionFilterAttribute
    {
        public bool ValidarAction { set; get; }
        public  bool Registrado { set; get; }
        public  bool Autorizado { set; get; }

        public bool Requiereinformacionpersonal { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {

                if (Requiereinformacionpersonal)
                {
                    var usuario = UsuarioData.getRegistroPorNombreUsuario(filterContext.HttpContext.User.Identity.Name);
                    var rolCliente = UsuariorolData.GetRegistrosPorIdUsuario(usuario.Id).Where(x => x.Idrolrol.Escliente).FirstOrDefault();
                    if (rolCliente != null)
                    {
                        var cliente = ClienteData.GetPorIdUsuario(usuario.Id);
                        if (cliente == null)
                        {
                            filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Cliente", action = "Editar", id = 0 }));
                        }
                    }
                }
            }
            else {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller="Login",action="Index"}));
            }
        }
    }
}