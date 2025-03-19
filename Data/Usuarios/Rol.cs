using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public partial class Rol
    {
        public static string NombreTabla = "usuarios_rol";
        public int Id { get; set; }

        public static string IdCampo = "usuarios_rol.id";
        public string Nombre { get; set; }

        public static string NombreCampo = "usuarios_rol.nombre";
        public bool Estaactivo { get; set; }

        public static string EstaactivoCampo = "usuarios_rol.esactivo";

        public bool Escliente { get; set; }

        public static string EsclienteCampo = "usuarios_rol.escliente";
        public Rol()
        {
        }

        public Rol(int p_id,string p_nombre, bool p_estaactivo, bool p_escliente)
        {
            Id = p_id;
            Nombre = p_nombre;
            Estaactivo = p_estaactivo;
            Escliente = p_escliente;
        }
    }
}
