﻿using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class CategoriaData
    {

        private static string selectTabla() { 
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append("SELECT productos_categoria.id,productos_categoria.codigo,productos_categoria.nombre,productos_categoria.estaactivo");
            stringBuilder.Append(" FROM productos_categoria");
            return stringBuilder.ToString();    
        }
        public static List<Categoria> getRegistros()
        {
            List<Categoria> registros = null;
            try {
                StringBuilder sql = new StringBuilder();
                sql.Append(selectTabla());
                Connection.openConection();
                var conexion=Connection.getConnection();
                registros = conexion.Query<Categoria>(sql.ToString()).ToList();
            }
            catch (Exception ex) {
                throw ex;
            }
            return registros;
        }

        public static Categoria getPorId(int id) {
            Categoria registro = null;
            try
            {
                StringBuilder sql=new StringBuilder();
                sql.Append(selectTabla());
                sql.Append(" WHERE ");
                sql.Append("productos_categoria.id=@id");
                Connection.openConection();
                var conexion=Connection.getConnection();
                DynamicParameters parametros=new DynamicParameters();
                parametros.Add("id",id);
                registro = conexion.QueryFirstOrDefault<Categoria>(sql.ToString(),parametros);
            }
            catch (Exception ex) {
                throw ex;
            }
            return registro;
        }
    }
}
