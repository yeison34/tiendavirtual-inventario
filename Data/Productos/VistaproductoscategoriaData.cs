using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class VistaproductoscategoriaData
    {
        private static string selectTabla()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT productos_vistaproductoscategoria.id,productos_vistaproductoscategoria.codigo,productos_vistaproductoscategoria.nombre,productos_vistaproductoscategoria.estaactivo");
            stringBuilder.Append(" FROM productos_vistaproductoscategoria");
            return stringBuilder.ToString();
        }
        public static List<Vistaproductoscategoria> getRegistros()
        {
            List<Vistaproductoscategoria> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(selectTabla());
                Connection.openConection();
                var conexion = Connection.getConnection();
                registros = conexion.Query<Vistaproductoscategoria>(sql.ToString()).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }
    }
}
