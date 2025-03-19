using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public partial class Usuario
    {
        public static string NombreTabla = "usuarios_usuario";

        public int Id { get; set; }

        public static string IdCampo = "usuarios_usuario.id";

        public string Nombreusuario { get; set; }

        public static string NombreusuarioCampo = "usuarios_usuario.nombreusuario";

        public string Contrasena { get; set; }

        public static string ContrasenaCampo = "usuarios_usuario.contrasena";

        public bool Esactivo { get; set; }

        public static string EsactivoCampo = "usuarios_usuario.esactivo";

        public string Correo { get; set; }

        public static string CorreoCampo = "usuarios_usuario.correo";
        public Usuario() { }

        public Usuario(int p_id,string p_nombreusuario,string p_contrasena,bool p_esactivo,string p_correo)
        {
            Id= p_id;
            Nombreusuario= p_nombreusuario;
            Contrasena= p_contrasena;
            Esactivo= p_esactivo;
            Correo= p_correo;
        }

    }
}
