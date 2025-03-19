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
        public static Estadoreservacionproducto GetEstadoReservacionProductoEstadoReservado()
        {
            Estadoreservacionproducto registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("productos_estadoreservacionproducto.esreservado=@esreservado");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("esreservado", true);
                registro = conexion.QueryFirstOrDefault<Estadoreservacionproducto>(sql.ToString(), parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static Estadoreservacionproducto GetEstadoReservacionProductoEstadoCancelado()
        {
            Estadoreservacionproducto registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("productos_estadoreservacionproducto.escancelado=@escancelado");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("escancelado", true);
                registro = conexion.QueryFirstOrDefault<Estadoreservacionproducto>(sql.ToString(), parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static Estadoreservacionproducto GetEstadoReservacionProductoEstadoEliminado()
        {
            Estadoreservacionproducto registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("productos_estadoreservacionproducto.eseliminado=@eseliminado");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("eseliminado", true);
                registro = conexion.QueryFirstOrDefault<Estadoreservacionproducto>(sql.ToString(), parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static Estadoreservacionproducto GetEstadoReservacionProductoEstadoComprado()
        {
            Estadoreservacionproducto registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("productos_estadoreservacionproducto.escomprado=@escomprado");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("escomprado", true);
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
