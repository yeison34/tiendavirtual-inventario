using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public partial class GeneroData
    {
        public static string SelectTabla()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT usuarios_genero.id,usuarios_genero.nombre,usuarios_genero.esmasculino,usuarios_genero.esfemenino,usuarios_genero.esotro,usuarios_genero.esactivo");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append("usuarios_genero");
            return stringBuilder.ToString();
        }

        public static List<Genero> GetRegistros()
        {
            List<Genero> registros = null;
            try {
                StringBuilder sql=new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Genero>(sql.ToString()).ToList();
            }catch(Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Genero GetPorId(int id)
        {
            Genero registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append(" usuarios_genero.id=@id ");
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                var conexion = Connection.getConnection();
                registro = conexion.QueryFirstOrDefault<Genero>(sql.ToString(),parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
