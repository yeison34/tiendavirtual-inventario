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
        private static string SelectTabla() { 
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append("SELECT productos_reservacionproducto.id,productos_reservacionproducto.idproducto,productos_reservacionproducto.fechareservacion,productos_reservacionproducto.idusuario,productos_reservacionproducto.idestadoreservacionproducto,productos_reservacionproducto.cantidad");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append("productos_reservacionproducto");
            return stringBuilder.ToString();
        }

        public static List<Reservacionproducto> GetRegistros() {
            List<Reservacionproducto> registros = null;
            try { 
                StringBuilder sql= new StringBuilder();
                sql.Append(SelectTabla());
                var conexion=Connection.getConnection();
                registros = conexion.Query<Reservacionproducto>(sql.ToString()).ToList();
            }catch(Exception ex) {
                throw ex;
            }
            return registros;
        }

        public static List<Reservacionproducto> GetRegistrosPorIdUsuario(int idusuario)
        {
            List<Reservacionproducto> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("productos_reservacionproducto.idusuario=@idusuario");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("idusuario", idusuario);
                registros = conexion.Query<Reservacionproducto>(sql.ToString(), parametros).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Reservacionproducto GetRegistroPorId(int id)
        {
            Reservacionproducto registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("productos_reservacionproducto.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                registro = conexion.QueryFirstOrDefault<Reservacionproducto>(sql.ToString(),parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static List<Reservacionproducto> GetRegistrosPorIdProducto(int id)
        {
            List<Reservacionproducto> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("productos_reservacionproducto.idproducto=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id", id);
                registros = conexion.Query<Reservacionproducto>(sql.ToString(),parametros).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Reservacionproducto InsertarRegistro(Reservacionproducto reservacionproducto)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO productos_reservacionproducto(id,idproducto,fechareservacion,idusuario,idestadoreservacionproducto,cantidad) values(@id,@idproducto,@fechareservacion,@idusuario,@idestadoreservacionproducto,@cantidad)");
                var conexion = Connection.getConnection();
                var id=conexion.ExecuteScalar<int>("select nextval('productos_reservacionproducto_id_seq'::regclass)");
                reservacionproducto.Id= id;
                conexion.Execute(sql.ToString(),reservacionproducto);
            }
            catch (Exception ex) {
                throw ex;
            }        
            return reservacionproducto;
        }

        public static void ActualizarRegistro(Reservacionproducto reservacionproducto)
        {
            try
            {
                StringBuilder sql=new StringBuilder();
                sql.Append("UPDATE productos_reservacionproducto set idproducto=@idproducto,fechareservacion=@fechareservacion,idusuario=@idusuario,idestadoreservacionproducto=@idestadoreservacionproducto,cantidad=@cantidad");
                sql.Append(" WHERE ");
                sql.Append("id=@id");
                var conexion = Connection.getConnection();
                conexion.Execute(sql.ToString(),reservacionproducto);
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
