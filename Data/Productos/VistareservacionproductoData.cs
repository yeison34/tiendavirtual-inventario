using Dapper;
using Data.Usuarios;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class VistareservacionproductoData
    {
        public static string SelectTabla() {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT productos_vistareservacionproducto.id,productos_vistareservacionproducto.idproducto,productos_vistareservacionproducto.fechareservacion,productos_vistareservacionproducto.idusuario,productos_vistareservacionproducto.idestadoreservacionproducto,productos_vistareservacionproducto.cantidad,productos_vistareservacionproducto.estadoreservacionproducto,productos_vistareservacionproducto.esreservado,productos_vistareservacionproducto.escancelado,productos_vistareservacionproducto.eseliminado,productos_vistareservacionproducto.escomprado,productos_vistareservacionproducto.identificacion,productos_vistareservacionproducto.nombrecliente,productos_vistareservacionproducto.nombreproducto,productos_vistareservacionproducto.descripcion,productos_vistareservacionproducto.descripcionproducto,productos_vistareservacionproducto.imagen,productos_vistareservacionproducto.preciocompra");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append("productos_vistareservacionproducto");
            return stringBuilder.ToString();
        }

        public static List<Vistareservacionproducto> GetRegistros() {
            List<Vistareservacionproducto> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Vistareservacionproducto>(sql.ToString()).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }
    }
}
