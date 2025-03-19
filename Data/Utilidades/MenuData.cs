using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Data.Utilidades
{
    public partial class MenuData
    {
        private static string selectTabla() { 
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append("SELECT utilidades_menu.id,utilidades_menu.codigo,utilidades_menu.nombre,utilidades_menu.controllername,utilidades_menu.actionname,utilidades_menu.idpadre,utilidades_menu.estaactivo");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append("utilidades_menu");
            return stringBuilder.ToString();    
        }
        public static List<Menu> getRegistros()
        {
            List<Menu> registros = null;
            try {
                string sql = selectTabla();
                var conexion=Connection.getConnection();
                registros = conexion.Query<Menu>(sql).ToList();
            }
            catch (Exception ex){
                throw ex;
            }
            return registros;
        }

        public static Menu getPorId(int id) {
            Menu registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(selectTabla());
                sql.Append(" WHERE ");
                sql.Append("utilidades_menu.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                registro=conexion.QueryFirstOrDefault<Menu>(sql.ToString(),parametros);
            }catch(Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
