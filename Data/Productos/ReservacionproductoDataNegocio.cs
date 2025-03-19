using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class ReservacionproductoData
    {
        public static Reservacionproducto GetRegistroPorIdUsuarioYIdProductoReservado(int idusuario,int idproducto)
        {
            Reservacionproducto registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" INNER JOIN ");
                sql.Append(Estadoreservacionproducto.NombreTabla);
                sql.Append($" ON {Reservacionproducto.IdestadoreservacionproductoCampo}={Estadoreservacionproducto.IdCampo}");
                sql.Append(" WHERE ");
                sql.Append($"{Reservacionproducto.IdusuarioCampo}=@idusuario");
                sql.Append(" AND ");
                sql.Append($"{Reservacionproducto.IdproductoCampo}=@idproducto");
                sql.Append(" AND ");
                sql.Append($"{Estadoreservacionproducto.EsreservadoCampo}=true");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("idusuario", idusuario);
                parametros.Add("idproducto", idproducto);
                registro = conexion.QueryFirstOrDefault<Reservacionproducto>(sql.ToString(), parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static Reservacionproducto GetReservacionProductoPorIdProducto(int id)
        {
            Reservacionproducto registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("productos_reservacionproducto.idproducto=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id", id);
                registro = conexion.QueryFirstOrDefault<Reservacionproducto>(sql.ToString(), parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static int GetCantidadProductosReservadosPorIdProducto(int idproducto)
        {
            int cantidad = 0;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append($"SELECT sum({Reservacionproducto.CantidadCampo})");
                sql.Append($" FROM {Reservacionproducto.NombreTabla} ");
                sql.Append(" WHERE ");
                sql.Append($"{Reservacionproducto.IdproductoCampo}=@idproducto");
                sql.Append($" group by {Reservacionproducto.IdproductoCampo}");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("idproducto", idproducto);
                cantidad = conexion.QueryFirstOrDefault<int>(sql.ToString(), parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cantidad;
        }
    }
}
