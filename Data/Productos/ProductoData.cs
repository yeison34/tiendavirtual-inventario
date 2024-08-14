using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class ProductoData
    {
        public static string selectTabla() { 
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append("SELECT productos_producto.id,productos_producto.codigo,productos_producto.nombre,productos_producto.descripcion,productos_producto.codigoqr,productos_producto.referencia,productos_producto.peso,productos_producto.idunidadmedida,productos_producto.preciocompra,productos_producto.idcategoria,productos_producto.idsubcategoria,productos_producto.cantidadstock,productos_producto.imagen,productos_producto.fechacreacion,productos_producto.fechamodificacion,productos_producto.estaactivo");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append(Producto.NombreTabla);
            return stringBuilder.ToString();
        }
        public static List<Producto> getRegistros()
        {
            List<Producto> registros = null;
            try
            {
                string sql = selectTabla();
                Connection.openConection();
                var conexion = Connection.getConnection();
                registros = conexion.Query<Producto>(sql).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Producto getRegistroPorId(int id) {
            Producto producto = null;
            try {
                StringBuilder sql = new StringBuilder();
                sql.Append(selectTabla());
                sql.Append(" WHERE ");
                sql.Append($"{Producto.IdCampo}=@id");
                Connection.openConection();
                var conexion=Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                producto = conexion.QueryFirstOrDefault<Producto>(sql.ToString(),parametros);
            }catch(Exception ex) 
            { 
                throw ex; 
            }
            return producto;
        }

        public static Producto insertarRegistro(Producto producto)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO productos_producto");
                sql.Append(" (id,codigo,nombre,descripcion,codigoqr,referencia,peso,idunidadmedida,preciocompra,idcategoria,idsubcategoria,cantidadstock,imagen,fechacreacion,fechamodificacion,estaactivo)");
                sql.Append(" values (@id,@codigo,@nombre,@descripcion,@codigoqr,@referencia,@peso,@idunidadmedida,@preciocompra,@idcategoria,@idsubcategoria,@cantidadstock,@imagen,@fechacreacion,@fechamodificacion,@estaactivo)");
                Connection.openConection();
                var conexion = Connection.getConnection();
                var id = conexion.ExecuteScalar<int>("SELECT nextval('productos_producto_id_seq'::regclass)");
                producto.Id = id;
                conexion.Execute(sql.ToString(),producto);
            }
            catch (Exception ex) {
                throw ex;
            }
            return producto;
        }

        public static void actualizarRegistro(Producto producto)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE productos_producto");
                sql.Append(" set codigo=@codigo,nombre=@nombre,descripcion=@descripcion,codigoqr=@codigoqr,referencia=@referencia,peso=@peso,idunidadmedida=@idunidadmedida,preciocompra=@preciocompra,idcategoria=@idcategoria,idsubcategoria=@idsubcategoria,cantidadstock=@cantidadstock,imagen=@imagen,fechacreacion=@fechacreacion,fechamodificacion=@fechamodificacion,estaactivo=@estaactivo");
                sql.Append(" WHERE ");
                sql.Append($"{Producto.IdCampo}=@id");
                Connection.openConection();
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",producto.Id);
                conexion.Execute(sql.ToString(), producto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
