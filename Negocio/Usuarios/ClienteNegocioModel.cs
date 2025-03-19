using Data.Usuarios;
using Data.Utilidades;
using Entities.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Negocio.Usuarios
{
    public partial class ClienteNegocioModel
    {
        public static ClienteModel GuardarInformacionCliente(ClienteModel cliente,int idusuario)
        {
            try
            {
                var clienteModel = ClienteData.GetPorId(cliente.Id);
                if (clienteModel == null)
                {                    
                    var clienteresult=ClienteData.InsertarRegistro(new Cliente(0,cliente.Idtipoidentificacion,cliente.Identificacion,cliente.Nombre,cliente.Apellido,cliente.Idgenero,cliente.Fechanacimiento,cliente.Idpais,cliente.Iddepartamento,cliente.Idmunicipio,idusuario));
                    cliente.Id = clienteresult.Id;
                }
                else {                    
                    var clienteresult = ClienteData.ActualizarRegistro(new Cliente(cliente.Id, cliente.Idtipoidentificacion, cliente.Identificacion, cliente.Nombre, cliente.Apellido, cliente.Idgenero, cliente.Fechanacimiento, cliente.Idpais, cliente.Iddepartamento, cliente.Idmunicipio, cliente.Idusuario));
                }
                CargarInformacionCLiente(cliente);
            }
            catch (Exception ex) {
                throw ex;
            }
            return cliente;
        }
        public static ClienteModel CargarInformacionCLiente(ClienteModel cliente) {
            try
            {           
                cliente.ListaTipoIdentificacion = TipoIdentificacionData.GetRegistros().Select(x => new SelectListItem { Text = x.Nombre, Value = x.Id.ToString() }).ToList();
                cliente.ListaGenero = GeneroData.GetRegistros().Select(x => new SelectListItem{ Text=x.Nombre,Value=x.Id.ToString()}).ToList();
                cliente.ListaPais = PaisData.GetRegistros().Select(x=>new SelectListItem { Text=x.Nombre,Value=x.Id.ToString()}).ToList();
                var clienteResult = ClienteData.GetPorId(cliente.Id);
                if (clienteResult != null)
                {
                    cliente.Id=clienteResult.Id;
                    cliente.Idtipoidentificacion = clienteResult.Idtipoidentificacion;
                    cliente.Identificacion=clienteResult.Identificacion;
                    cliente.Nombre=clienteResult.Nombre;
                    cliente.Apellido=clienteResult.Apellido;
                    cliente.Idgenero=clienteResult.Idgenero;
                    cliente.Fechanacimiento= clienteResult.Fechanacimiento;
                    cliente.Idpais= clienteResult.Idpais;
                    cliente.Iddepartamento= clienteResult.Iddepartamento;
                    cliente.Idmunicipio= clienteResult.Idmunicipio;
                    cliente.Idusuario= clienteResult.Idusuario;
                }
                else {
                    cliente.ListaTipoIdentificacion.Insert(0,new SelectListItem {Text="Seleccionar",Value=""});
                    cliente.ListaGenero.Insert(0, new SelectListItem { Text = "Seleccionar", Value = "" });
                    cliente.ListaPais.Insert(0, new SelectListItem { Text = "Seleccionar", Value = "" });
                    cliente.ListaDepartamento.Insert(0, new SelectListItem { Text = "Seleccionar", Value = "" });
                    cliente.ListaMunicipio.Insert(0, new SelectListItem { Text = "Seleccionar", Value = "" });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cliente;
        }        
    }
}
