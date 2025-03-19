using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class VistaproductosData
    {
        private static string selectTabla() {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT productos_vistaproductos.id,productos_vistaproductos.codigo,productos_vistaproductos.nombre,productos_vistaproductos.descripcion,productos_vistaproductos.codigoqr,productos_vistaproductos.referencia,productos_vistaproductos.peso,productos_vistaproductos.idunidadmedida,productos_vistaproductos.unidadmedida,productos_vistaproductos.preciocompra,productos_vistaproductos.idcategoria,productos_vistaproductos.categoria,productos_vistaproductos.idsubcategoria,productos_vistaproductos.subcategoria,productos_vistaproductos.cantidadstock,productos_vistaproductos.imagen,productos_vistaproductos.fechacreacion,productos_vistaproductos.fechamodificacion,productos_vistaproductos.estaactivo,productos_vistaproductos.porcentajeutilidad,productos_vistaproductos.precioventa");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append("productos_vistaproductos");
            return stringBuilder.ToString();
        }
        public static List<Vistaproductos> getRegistros()
        {
            List<Vistaproductos> registros = null;
            try { 
                StringBuilder sql=new StringBuilder();
                sql.Append(selectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Vistaproductos>(sql.ToString()).ToList();
            }catch(Exception ex) {
                throw ex;
            }
            return registros;
        }
    }
}
