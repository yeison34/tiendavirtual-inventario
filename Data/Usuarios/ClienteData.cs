using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public partial class ClienteData
    {
        public static string SelectTabla() { 
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append("SELECT usuarios_cliente.id,usuarios_cliente.idtipoidentificacion,usuarios_cliente.identificacion,usuarios_cliente.nombre,usuarios_cliente.apellido,usuarios_cliente.idgenero,usuarios_cliente.fechanacimiento,usuarios_cliente.idpais,usuarios_cliente.iddepartamento,usuarios_cliente.idmunicipio,usuarios_cliente.idusuario");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append("usuarios_cliente");
            return stringBuilder.ToString();
        }

        public static Cliente InsertarRegistro(Cliente cliente)
        {
            try {
                StringBuilder sql=new StringBuilder();
                sql.Append("INSERT INTO usuarios_cliente(id,idtipoidentificacion,identificacion,nombre,apellido,idgenero,fechanacimiento,idpais,iddepartamento,idmunicipio,idusuario)");
                sql.Append(" VALUES (@id,@idtipoidentificacion,@identificacion,@nombre,@apellido,@idgenero,@fechanacimiento,@idpais,@iddepartamento,@idmunicipio,@idusuario)");
                var conexion = Connection.getConnection();
                var id = conexion.ExecuteScalar<int>("SELECT nextval('usuarios_cliente_id_seq'::regclass)");
                cliente.Id = id;
                conexion.Execute(sql.ToString(),cliente);
            }catch(Exception ex)
            {
                throw ex;
            }
            return cliente;
        }

        public static Cliente ActualizarRegistro(Cliente cliente)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE usuarios_cliente set idtipoidentificacion=@idtipoidentificacion,identificacion=@identificacion,nombre=@nombre,apellido=@apellido,idgenero=@idgenero,fechanacimiento=@fechanacimiento,idpais=@idpais,iddepartamento=@iddepartamento,idmunicipio=@idmunicipio,idusuario=@idusuario");
                sql.Append(" WHERE ");
                sql.Append("id=@id");
                var conexion = Connection.getConnection();                
                conexion.Execute(sql.ToString(), cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cliente;
        }

        public static Cliente GetPorId(int id)
        {
            Cliente registro = null;
            try {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("usuarios_cliente.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                registro=conexion.QueryFirstOrDefault<Cliente>(sql.ToString(), parametros);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static Cliente GetPorIdentificacion(string identificacion)
        {
            Cliente registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("usuarios_cliente.identificacion=@identificacion");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("identificacion", identificacion);
                registro = conexion.QueryFirstOrDefault<Cliente>(sql.ToString(), parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static Cliente GetPorIdUsuario(int idusuario)
        {
            Cliente registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("usuarios_cliente.idusuario=@idusuario");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("idusuario", idusuario);
                registro = conexion.QueryFirstOrDefault<Cliente>(sql.ToString(), parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
