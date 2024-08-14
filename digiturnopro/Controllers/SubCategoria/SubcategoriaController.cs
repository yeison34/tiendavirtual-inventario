using Data.Productos;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace digiturnopro.Controllers.SubCategoria
{
    public class SubcategoriaController : Controller
    {
        // GET: SubCategoria
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SubCategoriaPorCategoria(int id) { 
            List<SelectListItem> subcategorias=new List<SelectListItem>();
            try
            {
                subcategorias=SubcategoriaData.getPorIdCategoria(id).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = $"{x.Codigo} - {x.Nombre}" }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                Connection.closeConnection();
            }
            return Json(subcategorias,JsonRequestBehavior.AllowGet);
        }
    }
}