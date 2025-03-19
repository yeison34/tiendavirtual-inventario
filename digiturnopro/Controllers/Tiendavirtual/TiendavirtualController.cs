using Data.Productos;
using Data.Usuarios;
using Data.Utilidades;
using Entities.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;

namespace digiturnopro.Controllers.Tiendavirtual
{
    
    public class TiendavirtualController : Controller
    {
        [FiltroWeb(ValidarAction = true, Registrado = true, Autorizado = true, Requiereinformacionpersonal = true)]
        public ActionResult Index()
        {
            ProductoscategoriaModel model = new ProductoscategoriaModel();
            try
            {
                model.listaProductos = VistaproductosData.getRegistros().Select(x => new VistaproductosModel(x.Id, x.Codigo, x.Nombre, x.Descripcion, x.Codigoqr, x.Referencia, x.Peso, x.Idunidadmedida, x.Unidadmedida, x.Preciocompra, x.Idcategoria, x.Categoria, x.Idsubcategoria, x.Subcategoria, x.Cantidadstock, x.Imagen, x.Fechacreacion, x.Fechamodificacion, x.Estaactivo, x.Porcentajeutilidad, x.Precioventa)).ToList();
                model.listaCategorias = VistaproductoscategoriaData.getRegistros().Select(x => new VistaproductoscategoriaModel(x.Id, x.Codigo, x.Nombre, x.Estaactivo)).ToList();
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
        public JsonResult ReservaProducto(int idproducto, bool esincrementar, bool esdecrementar)
        {
            ProductoModel model = null;
            int puedeReservar = 0;
            int topeStok = 50;
            try
            {
                var usuario = UsuarioData.getRegistroPorNombreUsuario(User.Identity.Name);
                var producto = ProductoData.GetRegistroPorId(idproducto);
                var estadoReservado = EstadoreservacionproductoData.GetEstadoReservacionProductoEstadoReservado();
                var estadoCancelado = EstadoreservacionproductoData.GetEstadoReservacionProductoEstadoCancelado();
                var estadoEliminado = EstadoreservacionproductoData.GetEstadoReservacionProductoEstadoEliminado();
                if (producto == null)
                {
                    throw new Exception("No existe el producto");
                }
                var resevacionProducto = ReservacionproductoData.GetRegistroPorIdUsuarioYIdProductoReservado(usuario.Id, idproducto);
                var cantidadReservacionOnline = ReservacionproductoData.GetCantidadProductosReservadosPorIdProducto(idproducto);
     
                if (esincrementar)
                {
                    if (resevacionProducto == null)
                    {
                        if (producto.Cantidadstock > (topeStok+ (cantidadReservacionOnline==0?1: cantidadReservacionOnline)))
                        {
                            ReservacionproductoData.InsertarRegistro(new Reservacionproducto(0, idproducto, DateTime.Now, usuario.Id, estadoReservado.Id, 1));
                            puedeReservar = producto.Cantidadstock > (topeStok + (cantidadReservacionOnline == 0 ? 1 : cantidadReservacionOnline)) ? 1 : 0;
                        }
                        else
                        {
                            return Json(new { fuereservado = 0, puedereservar = 0 }, JsonRequestBehavior.AllowGet);
                        }
                    }
                    else
                    {
                        if (producto.Cantidadstock > (topeStok + cantidadReservacionOnline))
                        {
                            resevacionProducto.Cantidad += 1;
                            ReservacionproductoData.ActualizarRegistro(resevacionProducto);
                            puedeReservar = producto.Cantidadstock > (topeStok + cantidadReservacionOnline) ? 1 : 0;
                        }
                        else
                        {
                            return Json(new { fuereservado = 0, puedereservar = 0 }, JsonRequestBehavior.AllowGet);
                        }
                    }
                }
                else if (esdecrementar)
                {
                    if (resevacionProducto!=null) {
                        resevacionProducto.Cantidad -= 1;
                        ReservacionproductoData.ActualizarRegistro(resevacionProducto);
                        puedeReservar = producto.Cantidadstock > (topeStok + cantidadReservacionOnline) ? 1 : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                Json(new { mensaje = ex.Message }, JsonRequestBehavior.AllowGet);
            }
            finally
            {
                Connection.closeConnection();
            }

            return Json(new { fuereservado = 1, puedereservar = puedeReservar }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Carrito()
        {
            List<VistareservacionproductoModel> productosReservados = null;
            try
            {
                var usuario = UsuarioData.getRegistroPorNombreUsuario(User.Identity.Name);
                productosReservados = VistareservacionproductoData.GetRegistrosPorIdUsuario(usuario.Id).Select(x=>new VistareservacionproductoModel(x.Id,x.Idproducto,x.Fechareservacion,x.Idusuario,x.Idestadoreservacionproducto,x.Cantidad??0,x.Estadoreservacionproducto,x.Esreservado,x.Escancelado,x.Eseliminado,x.Escomprado,x.Identificacion,x.Nombrecliente,x.Nombreproducto,x.Descripcion,x.Descripcionproducto,x.Imagen,x.Preciocompra)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.closeConnection();
            }
            return View(productosReservados);
        }
    }
}