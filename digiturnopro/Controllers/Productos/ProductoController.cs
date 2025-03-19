using Data.Productos;
using Data.Utilidades;
using Entities.Productos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace digiturnopro.Controllers
{
    public class ProductoController : Controller
    {

        [FiltroWeb(ValidarAction = true, Registrado = true, Autorizado = true, Requiereinformacionpersonal = true)]
        public ActionResult Index()
        {
            List<ProductoModel> lista= new List<ProductoModel>();
            try
            {
                lista = ProductoData.GetRegistros().Where(x=>x.Estaactivo==true).Select(x => new ProductoModel(x.Id, x.Codigo, x.Nombre, x.Descripcion, x.Codigoqr, x.Referencia, x.Peso,x.Idunidadmedida, x.Preciocompra,x.Idcategoria,x.Idsubcategoria, x.Cantidadstock, x.Imagen, x.Fechacreacion, x.Fechamodificacion,x.Estaactivo)).ToList();
            }catch(Exception ex) {
                throw ex;
            }
            finally
            {
                Connection.closeConnection();
            }
            return View(lista);
        }

        [FiltroWeb(ValidarAction = true, Registrado = true, Autorizado = true, Requiereinformacionpersonal = true)]
        public ActionResult Editar(int id){
            ProductoEditModel model = new ProductoEditModel();
            try {
                model.Categorias = CategoriaData.GetRegistros().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = $"{x.Codigo} - {x.Nombre}" }).ToList();
                model.UnidadesMedida = UnidadmedidaData.getRegistros().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = $"{x.Codigo} - {x.Nombre}" }).ToList();
                if (id != 0)
                {
                    var producto = ProductoData.GetRegistroPorId(id);
                    model.Id = producto.Id;
                    model.Codigo = producto.Codigo;
                    model.Nombre = producto.Nombre;
                    model.Descripcion = producto.Descripcion;
                    model.Codigoqr = producto.Codigoqr;
                    model.Referencia = producto.Referencia;
                    model.Peso = producto.Peso;
                    model.Idunidadmedida = producto.Idunidadmedida;
                    model.Preciocompra = producto.Preciocompra;
                    model.Idcategoria = producto.Idcategoria;
                    model.Idsubcategoria = producto.Idsubcategoria;
                    model.Cantidadstock = producto.Cantidadstock;
                    model.Fechacreacion = producto.Fechacreacion;
                    model.Fechamodificacion = producto.Fechamodificacion;
                    model.Estaactivo = producto.Estaactivo;
                    model.Imagen = producto.Imagen;
                }
                else {
                    model.Idcategoria = 1;
                }
                model.SubCategorias = SubcategoriaData.getPorIdCategoria(model.Idcategoria ?? 0).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = $"{x.Codigo} - {x.Nombre}" }).ToList();
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

        [HttpPost]
        public ActionResult Guardar(ProductoEditModel model) {
            try
            {
                guardarImagen(model);
                if (model.Id == 0)
                {
                    
                    var producto = new Producto(model.Id, model.Codigo, model.Nombre, model.Descripcion, model.Codigoqr, model.Referencia, model.Peso, model.Idunidadmedida,model.Preciocompra,model.Idcategoria,model.Idsubcategoria, model.Cantidadstock, model.Imagen, DateTime.Now, DateTime.Now, model.Estaactivo);
                    ProductoData.InsertarRegistro(producto);
                    model.Id = producto.Id;
                }
                else {
                    var producto = ProductoData.GetRegistroPorId(model.Id);
                    if (producto!=null) {
                        producto.Nombre= model.Nombre;
                        producto.Descripcion=model.Descripcion;
                        producto.Codigoqr = model.Codigoqr;
                        producto.Referencia = model.Referencia;
                        producto.Peso = model.Peso;
                        producto.Idunidadmedida= model.Idunidadmedida;
                        producto.Preciocompra = model.Preciocompra;
                        producto.Idcategoria = model.Idcategoria;
                        producto.Idsubcategoria = model.Idsubcategoria;
                        producto.Cantidadstock = model.Cantidadstock;
                        producto.Fechamodificacion = DateTime.Now;
                        producto.Estaactivo = model.Estaactivo;
                        producto.Imagen=model.Imagen;
                    }
                    ProductoData.ActualizarRegistro(producto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                Connection.closeConnection();
            }
            return RedirectToAction("Editar",new { id = model.Id });
        }

        public void guardarImagen(ProductoEditModel model) {
            try
            {
                if (model.UploadImagen!=null && model.UploadImagen.ContentLength>0) {
                    var path = Server.MapPath($"~/Images/Productos/{model.Imagen}");
                    if (!System.IO.File.Exists(path)) {
                        var name = $"{model.Codigo}{model.UploadImagen.FileName}";
                        model.UploadImagen.SaveAs($"{path}/{name}");
                        model.Imagen = name;
                    }
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public ActionResult Eliminar(int id)
        {
            try
            {
                Producto producto = ProductoData.GetRegistroPorId(id);
                if (producto!=null) {
                    producto.Estaactivo = false;
                    ProductoData.ActualizarRegistro(producto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                Connection.closeConnection();
            }
            return RedirectToAction("Index");
        }

        public JsonResult Producto(int id)
        {
            ProductoModel producto = null;
            try
            {
                var model = ProductoData.GetRegistroPorId(id);
                if (model != null)
                {
                    producto = new ProductoModel(model.Id, model.Codigo, model.Nombre, model.Descripcion, model.Codigoqr, model.Referencia, model.Peso, model.Idunidadmedida, model.Preciocompra, model.Idcategoria, model.Idsubcategoria, model.Cantidadstock, model.Imagen, DateTime.Now, DateTime.Now, model.Estaactivo);
                }
                else {
                    throw new Exception("Ha ocuurido un error al consultar el producto");
                }
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new { mensaje = ex.Message }, JsonRequestBehavior.AllowGet);
            }
            finally { 
                Connection.closeConnection();
            }
            return Json(producto,JsonRequestBehavior.AllowGet);  
        }
    }
}