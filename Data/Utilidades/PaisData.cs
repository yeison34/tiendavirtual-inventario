using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utilidades
{
    public partial class PaisData
    {
        public static string SelectTabla() { 
            StringBuilder stringBuilder=new StringBuilder();
            stringBuilder.Append("SELECT utilidades_pais.id,utilidades_pais.codigo,utilidades_pais.nombre,utilidades_pais.estaactivo");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append("utilidades_pais");
            return stringBuilder.ToString();
        }
        public static List<Pais> GetRegistros()
        {
            List<Pais> registros = null;
            try { 
                StringBuilder sql=new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Pais>(sql.ToString()).ToList();
            }catch(Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Pais GetPorId(int id)
        {
            Pais registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id", id);
                registro = conexion.QueryFirstOrDefault<Pais>(sql.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
