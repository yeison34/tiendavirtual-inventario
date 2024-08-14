using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace digiturnopro
{
    public class FiltroWeb : ActionFilterAttribute
    {
        public bool ValidarAction { set; get; }
        public  bool Registrado { set; get; }
        public  bool Autorizado { set; get; }
        public override void OnActionExecuting(ActionExecutingContext filterContext) {
            var respuesta = ValidarAction;
            base.OnActionExecuting(filterContext);
        }
    }
}