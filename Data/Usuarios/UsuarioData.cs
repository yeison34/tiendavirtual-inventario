using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public partial class UsuarioData
    {
        private static string selectTabla() { 
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append("SELECT usuarios_usuario.id,usuarios_usuario.nombreusuario,usuarios_usuario.contrasena,usuarios_usuario.esactivo,usuarios_usuario.correo");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append("usuarios_usuario");
            return stringBuilder.ToString();
        }

        public static Usuario insertarRegistro(Usuario usuario)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO usuarios_usuario (id,nombreusuario,contrasena,esactivo,correo) values(@id,@nombreusuario,@contrasena,@esactivo,@correo)");
                var conexion = Connection.getConnection();
                var id = conexion.ExecuteScalar<int>("SELECT nextval('usuarios_usuario_id_seq'::regclass)");
                usuario.Id = id;
                conexion.Execute(sql.ToString(), usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuario;
        }

        public static void actualizarRegistro(Usuario usuario)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE usuarios_usuario set nombreusuario=@nombreusuario,contrasena=@contrasena,esactivo=@esactivo,correo=@correo");
                sql.Append(" WHERE id=@id");
                var conexion = Connection.getConnection();
                conexion.Execute(sql.ToString(), usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Usuario getRegistroPorId(int id)
        {
            Usuario registro = null;
            try { 
            
                StringBuilder sql= new StringBuilder();
                sql.Append(selectTabla());
                sql.Append(" WHERE ");
                sql.Append("usuarios_usuario.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                registro = conexion.QueryFirstOrDefault<Usuario>(sql.ToString(),parametros);
            }catch(Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static Usuario getRegistroPorNombreUsuario(string nombreusuario)
        {
            Usuario registro = null;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(selectTabla());
                sql.Append(" WHERE ");
                sql.Append("usuarios_usuario.nombreusuario=@nombreusuario");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("nombreusuario", nombreusuario);
                registro = conexion.QueryFirstOrDefault<Usuario>(sql.ToString(), parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        
        public static Usuario getUsuarioPorCorreo(string correo) {
            Usuario registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(selectTabla());
                sql.Append(" WHERE ");
                sql.Append(" correo=@correo");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("correo",correo);
                registro = conexion.QueryFirstOrDefault<Usuario>(sql.ToString(),parametros);
            }
            catch (Exception ex) {
                throw ex;
            }
            return registro;
        }
    }
}
