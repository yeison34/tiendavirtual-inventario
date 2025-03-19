using Data.Usuarios;
using Entities.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Usuarios
{
    public partial class UsuarioNegocioModel
    {
        public static Usuario VerificarCreacionUsuario(UsuarioModel usuario)
        {
            Usuario usuarioRegistrado = null;
            try
            {
                var existeNombreUsuario = UsuarioData.getRegistroPorNombreUsuario(usuario.Nombreusuario);
                if (existeNombreUsuario != null)
                {
                    throw new Exception("El usuario con el nombre usuario especificado ya se encuentra registrado");
                }
                var usuarioExiste = UsuarioData.getUsuarioPorCorreo(usuario.Correo);
                if (usuarioExiste!=null) {
                    throw new Exception("El usuario con el correo especificado ya se encuentra registrado");
                }
                if (usuario.Contrasena!=usuario.Passwordconfirm) {
                    throw new Exception("Las contraseñas no coinciden");
                }
                usuarioRegistrado = UsuarioData.insertarRegistro(new Usuario(0,usuario.Nombreusuario,usuario.Contrasena,true,usuario.Correo));
                var rolCliente = RolData.GetRolEsCliente();
                UsuariorolData.InsertarRegistro(new Usuariorol(0,rolCliente.Id,usuarioRegistrado.Id,true));
            }
            catch (Exception ex) {
                throw ex;
            }
            return usuarioRegistrado;
        }
    }
}
