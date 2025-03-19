using Dapper;
using Data.Utilidades;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class SubcategoriaData
    {
        private static string selectTabla() { 
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append("SELECT productos_subcategoria.id,productos_subcategoria.codigo,productos_subcategoria.nombre,productos_subcategoria.idcategoria,productos_subcategoria.estaactivo,productos_subcategoria.porcentajeutilidad");
            stringBuilder.Append(" FROM productos_subcategoria");
            return stringBuilder.ToString();    
        }

        public static List<Subcategoria> getRegistros() {
            List<Subcategoria> registros = null;
            try
            {
                StringBuilder sql= new StringBuilder();
                sql.Append(selectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Subcategoria>(sql.ToString()).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Subcategoria getPorId(int id) {
            Subcategoria registro = null;
            try {
                StringBuilder sql = new StringBuilder();
                sql.Append(selectTabla());
                sql.Append(" WHERE ");
                sql.Append("productos_subcategoria.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                registro=conexion.QueryFirstOrDefault<Subcategoria>(sql.ToString(),parametros);
            }catch(Exception ex) {
                throw ex;
            }
            return registro;
        }

        public static List<Subcategoria> getPorIdCategoria(int id)
        {
            List<Subcategoria> registros= null;
            try {
                StringBuilder sql= new StringBuilder();
                sql.Append(selectTabla());
                sql.Append(" WHERE ");
                sql.Append("productos_subcategoria.idcategoria=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                registros = conexion.Query<Subcategoria>(sql.ToString(), parametros).ToList();
            }
            catch (Exception ex) {
                throw ex;
            }
            return registros;
        }
    }
}
