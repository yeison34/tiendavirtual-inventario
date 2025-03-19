using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public partial class RolData
    {
        public static Rol GetRolEsCliente()
        {
            Rol registro = null;
            try
            {
                StringBuilder sql= new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append($"{Rol.EsclienteCampo}=@escliente");
                DynamicParameters parametros=new DynamicParameters();
                parametros.Add("escliente",true);
                var conexion = Connection.getConnection();
                registro = conexion.QueryFirst<Rol>(sql.ToString(),parametros);
            }
            catch (Exception ex) {
                throw ex;
            }

            return registro;
        }
    }
}
