using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public partial class TipoIdentificacionData
    {
        public static string SelectTabla() {
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append("SELECT usuarios_tipoidentificacion.id,usuarios_tipoidentificacion.nombre,usuarios_tipoidentificacion.esactivo");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append("usuarios_tipoidentificacion");
            return stringBuilder.ToString();
        }

        public static List<Tipoidentificacion> GetRegistros()
        {
            List<Tipoidentificacion> registros = null;
            try
            {
                StringBuilder sql= new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros=conexion.Query<Tipoidentificacion>(sql.ToString()).ToList();
            }
            catch (Exception ex) {
                throw ex;
            }
            return registros;
        }

        public static Tipoidentificacion GetPorId(int id) {
            Tipoidentificacion registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append(" usuarios_tipoidentificacion.id=@id ");
                var conexion = Connection.getConnection();
                DynamicParameters parametros=new DynamicParameters();
                parametros.Add("id",id);
                registro = conexion.QueryFirstOrDefault<Tipoidentificacion>(sql.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
