using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public partial class Tipoidentificacion
    {
        public static string Nombretablea = "usuarios_tipoidentificacion";

        public int Id { get; set; }

        public static string IdCampo = "usuarios_tipoidentificacion.id";

        public string Nombre { get; set;}

        public static string NombreCampo ="usuarios_tipoidentificacion.nombre";

        public bool Esactivo { get; set; }

        public static string EsactivoCampo ="usuarios_tipoidentificacion.esactivo";

        public Tipoidentificacion() { }

        public Tipoidentificacion(int p_id, string p_nombre, bool p_esactivo)
        {
            Id = p_id;
            Nombre = p_nombre;
            Esactivo = p_esactivo;
        }
    }
}
