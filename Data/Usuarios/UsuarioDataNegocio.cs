using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public partial class UsuarioData
    {
        public static Usuario getUsuarioPorNombreUsuarioYContrasena(string usuario,string contrasena) {
            Usuario registro = null;
            try
            {
                StringBuilder sql=new StringBuilder();
                sql.Append(selectTabla());
                sql.Append(" WHERE ");
                sql.Append(" nombreusuario=@usuario AND contrasena=@contrasena ");
                DynamicParameters parametros= new DynamicParameters();
                parametros.Add("usuario",usuario);
                parametros.Add("contrasena",contrasena);
                var conexion = Connection.getConnection();
                registro=conexion.QueryFirstOrDefault<Usuario>(sql.ToString(),parametros);
            }
            catch (Exception ex) {
                throw ex;
            }
            return registro;
        }
    }
}
