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
        public static List<Vistareservacionproducto> GetRegistrosPorIdUsuario(int idusuario)
        {
            List<Vistareservacionproducto> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append($"{Vistareservacionproducto.IdusuarioCampo}=@idusuario");
                var conexion = Connection.getConnection();
                DynamicParameters parametros= new DynamicParameters();
                parametros.Add("idusuario",idusuario);
                registros = conexion.Query<Vistareservacionproducto>(sql.ToString(),parametros).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }        
    }
}
