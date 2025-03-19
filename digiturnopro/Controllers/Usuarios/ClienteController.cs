using Data.Usuarios;
using Data.Utilidades;
using Entities.Usuarios;
using Negocio.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace digiturnopro.Controllers.Usuarios
{
    public class ClienteController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Editar(int id) {
            ClienteModel cliente = new ClienteModel();
            try {     
                cliente.Id = id;
                cliente=ClienteNegocioModel.CargarInformacionCLiente(cliente);
            }catch(Exception ex)
            {
                throw ex;
            }finally { 
                Connection.closeConnection();
            }     
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Guardar(ClienteModel cliente)
        {
            try
            {
                if (!ModelState.IsValid) {
                    foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                    {
                        // Ver los errores de validación en el servidor
                        Console.WriteLine(error.ErrorMessage);
                    }
                    return View("Editar",cliente);
                }
                var usuario = UsuarioData.getRegistroPorNombreUsuario(User.Identity.Name);
                cliente=ClienteNegocioModel.GuardarInformacionCliente(cliente,usuario.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                Connection.closeConnection();
            }
            return RedirectToAction("Editar", new { id=cliente.Id});
        }
    }
}