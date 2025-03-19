using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public partial class UsuariorolData
    {
        public static string SelectTabla() {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT usuarios_usuariorol.id,usuarios_usuariorol.idrol,usuarios_usuariorol.idusuario,usuarios_usuariorol.esactivo");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append("usuarios_usuariorol");
            return stringBuilder.ToString();
        }

        public static Usuariorol InsertarRegistro(Usuariorol usuariorol)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO usuarios_usuariorol(id,idrol,idusuario,esactivo)");
                sql.Append(" VALUES(@id,@idrol,@idusuario,@esactivo)");
                var conexion = Connection.getConnection();
                var id = conexion.ExecuteScalar<int>("SELECT nextval('usuarios_usuariorol_id_seq'::regclass)");
                usuariorol.Id = id;
                conexion.Execute(sql.ToString(),usuariorol);
            }
            catch (Exception ex) {
                throw ex;
            }
            return usuariorol;
        }
        public static List<Usuariorol> GetRegistros()
        {
            List<Usuariorol> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Usuariorol>(sql.ToString()).ToList();
            }
            catch (Exception ex) {
                throw ex;
            }
            return registros;
        }

        public static Usuariorol GetPorId(int id)
        {
            Usuariorol registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("usuarios_usuariorol.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                registro = conexion.QueryFirstOrDefault<Usuariorol>(sql.ToString(),parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static List<Usuariorol> GetRegistrosPorIdUsuario(int idusuario)
        {
            List<Usuariorol> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("usuarios_usuariorol.idusuario=@idusuario");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("idusuario", idusuario);
                registros = conexion.Query<Usuariorol>(sql.ToString(),parametros).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }
    }
}
