using Data.Productos;
using Data.Utilidades;
using Entities.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace digiturnopro.Controllers.Tiendavirtual
{
    public class TiendavirtualController : Controller
    {
        // GET: TiendaVirtual
        public ActionResult Index()
        {
            ProductoscategoriaModel model = new ProductoscategoriaModel();
            try
            {
                model.listaProductos = VistaproductosData.getRegistros().Select(x => new VistaproductosModel(x.Id, x.Codigo, x.Nombre, x.Descripcion, x.Codigoqr, x.Referencia, x.Peso, x.Idunidadmedida,x.Unidadmedida,x.Preciocompra, x.Idcategoria,x.Categoria,x.Idsubcategoria,x.Subcategoria,x.Cantidadstock, x.Imagen, x.Fechacreacion, x.Fechamodificacion, x.Estaactivo,x.Porcentajeutilidad,x.Precioventa)).ToList();
                model.listaCategorias = VistaproductoscategoriaData.getRegistros().Select(x=>new VistaproductoscategoriaModel(x.Id,x.Codigo,x.Nombre,x.Estaactivo)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.closeConnection();
            }
            return View(model);
        }
    }
}