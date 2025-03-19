using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utilidades
{
    public partial class MunicipioData
    {
        public static string SelectTabla()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT utilidades_municipio.id,utilidades_municipio.codigo,utilidades_municipio.nombre,utilidades_municipio.iddepartamento,utilidades_municipio.estaactivo");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append("utilidades_municipio");
            return stringBuilder.ToString();
        }
        public static List<Municipio> GetRegistros()
        {
            List<Municipio> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Municipio>(sql.ToString()).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Municipio GetPorId(int id)
        {
            Municipio registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("utilidades_municipio.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id", id);
                registro = conexion.QueryFirstOrDefault<Municipio>(sql.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static Municipio GetPorIdDepartamento(int id)
        {
            Municipio registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("utilidades_municipio.iddepartamento=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id", id);
                registro = conexion.QueryFirstOrDefault<Municipio>(sql.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
