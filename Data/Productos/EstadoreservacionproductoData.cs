using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class EstadoreservacionproductoData
    {
        public static string SelectTabla() { 
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append("SELECT productos_estadoreservacionproducto.id,productos_estadoreservacionproducto.nombre,productos_estadoreservacionproducto.esactivo,productos_estadoreservacionproducto.esreservado,productos_estadoreservacionproducto.escancelado,productos_estadoreservacionproducto.eseliminado,productos_estadoreservacionproducto.escomprado");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append("productos_estadoreservacionproducto");
            return stringBuilder.ToString();    
        }
        public static List<Estadoreservacionproducto> GetRegistros()
        {
            List<Estadoreservacionproducto> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Estadoreservacionproducto>(sql.ToString()).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Estadoreservacionproducto GetPorId(int id)
        {
            Estadoreservacionproducto registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("productos_estadoreservacionproducto.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id", id);
                registro = conexion.QueryFirstOrDefault<Estadoreservacionproducto>(sql.ToString(), parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
