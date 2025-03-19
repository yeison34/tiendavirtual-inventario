using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public partial class Cliente
    {
        public static string NombreTabla = "usuarios_cliente";

        public int Id { get; set; }

        public static string Idcampo = "usuarios_cliente.id";
        public int? Idtipoidentificacion { get; set; }

        public static string IdtipoidentificacionCampo = "usuarios_cliente.idtipoidentificacion";

        public Tipoidentificacion Idtipoidentificaciontipoidentificacion
        {
            get {
                return TipoIdentificacionData.GetPorId(Idtipoidentificacion??0);
            }
        }
        public string Identificacion { get; set; }

        public static string IdentificacionCampo = "usuarios_cliente.identificacion";

        public string Nombre { get; set; }

        public static string NombreCampo = "usuarios_cliente.nombre";

        public string Apellido { get; set; }

        public static string ApellidoCampo = "usuarios_cliente.apellido";

        public int? Idgenero { get; set; }

        public static string IdgeneroCampo = "usuarios_cliente.idgenero";

        public Genero Idgenerogenero
        {
            get {
                return GeneroData.GetPorId(Idgenero??0);
            }
        }
        public DateTime? Fechanacimiento { get; set; }

        public static string FechanacimientoCampo = "usuarios_cliente.fechanacimiento";
        public int? Idpais { get; set; }

        public static string IdpaisCampo = "usuarios_cliente.idpais";

        public Pais Idpaispais
        {
            get {
                return PaisData.GetPorId(Idpais??0);
            }
        }

        public int? Iddepartamento { get; set; }

        public static string IddepartamentoCampo = "usuarios_cliente.iddepartamento";

        public Departamento Iddepartamentodepartamento
        {
            get {
                return DepartamentoData.GetPorId(Iddepartamento??0);
            }
        }

        public int? Idmunicipio { get; set; }

        public static string IdmunicipioCampo = "usuarios_cliente.idmunicipio";

        public Municipio Idmunicipiomunicipio
        {
            get {
                return MunicipioData.GetPorId(Idmunicipio??0);
            }
        }

        public int? Idusuario { get; set; }

        public static string IdusuarioCampo = "usuarios_cliente.idusuario";

        public Usuario Idusuariousuario
        {
            get {
                return UsuarioData.getRegistroPorId(Idusuario??0);
            }
        }

        public Cliente() { }

        public Cliente(int p_id,int? p_idtipoidentificacion,string p_identificacion,string p_nombre,string p_apellido,int? p_idgenero,DateTime? p_fechanacimiento,int? p_idpais,int? p_iddepartamento,int? p_idmunicipio,int? p_idusuario) {
            Id = p_id;
            Idtipoidentificacion = p_idtipoidentificacion;
            Identificacion = p_identificacion;
            Nombre = p_nombre;
            Apellido = p_apellido;
            Idgenero = p_idgenero;
            Fechanacimiento = p_fechanacimiento;
            Idpais = p_idpais;
            Iddepartamento = p_iddepartamento;
            Idmunicipio = p_idmunicipio;
            Idusuario = p_idusuario;
        }
    }
}
