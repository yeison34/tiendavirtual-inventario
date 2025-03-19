using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class UnidadmedidaData
    {
        private static string selectTabla()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT productos_unidadmedida.id,productos_unidadmedida.codigo,productos_unidadmedida.nombre,productos_unidadmedida.cantidad,productos_unidadmedida.estaactivo");
            stringBuilder.Append(" FROM productos_unidadmedida");
            return stringBuilder.ToString();
        }

        public static List<Unidadmedida> getRegistros()
        {
            List<Unidadmedida> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(selectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Unidadmedida>(sql.ToString()).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Unidadmedida getPorId(int id)
        {
            Unidadmedida registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(selectTabla());
                sql.Append(" WHERE ");
                sql.Append("productos_unidadmedida.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id", id);
                registro = conexion.QueryFirstOrDefault<Unidadmedida>(sql.ToString(), parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
