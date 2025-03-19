using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public partial class Usuariorol
    {
        public static string NombreTabla = "usuarios_usuariorol";
        public int Id { get; set; }

        public static string IdCampo = "usuarios_usuariorol.id";

        public int? Idrol { get; set; }

        public static string IdrolCampo = "usuarios_usuariorol.idrol";

        public Rol Idrolrol
        {
            get {
                return RolData.GetRegistroPorId(Idrol??0);
            }
        }
        public int? Idusuario { get; set; }

        public static string IdusuarioCampo = "usuarios_usuariorol.idusuario";

        public Usuario Idusuariousuario
        {
            get {
                return UsuarioData.getRegistroPorId(Idusuario??0);
            }
        }
        public bool Esactivo { get; set; }

        public static string EsactivoCampo = "usuarios_usuariorol.esactivo";

        public Usuariorol()
        {
        }

        public Usuariorol(int p_id, int? p_idrol, int? p_idusuario, bool p_esactivo)
        {
            Id = p_id;
            Idrol = p_idrol;
            Idusuario= p_idusuario;
            Esactivo = p_esactivo;
        }
    }
}
