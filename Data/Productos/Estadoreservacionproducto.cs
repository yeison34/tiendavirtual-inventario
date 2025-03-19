using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class Estadoreservacionproducto
    {
        public static string NombreTabla = "productos_estadoreservacionproducto";

        public int Id { get; set; }

        public static string IdCampo = "productos_estadoreservacionproducto.id";
        public string Nombre { get; set;}

        public static string NombreCampo = "productos_estadoreservacionproducto.nombre";

        public bool Esactivo { get; set; }

        public static string EsactuvoCampo = "productos_estadoreservacionproducto.esactivo";

        public bool Esreservado { get; set; }

        public static string EsreservadoCampo = "productos_estadoreservacionproducto.esreservado";
        public bool Escancelado { get; set; }

        public static string EscanceladoCampo = "productos_estadoreservacionproducto.escancelado";

        public bool Eseliminado { get; set; }

        public static string EseliminadoCampo = "productos_estadoreservacionproducto.eseliminado";

        public bool Escomprado { get; set; }

        public static string EscompradoCampo = "productos_estadoreservacionproducto.escomprado";

        public Estadoreservacionproducto() { }

        public Estadoreservacionproducto(int p_id,string p_nombre,bool p_esactivo,bool p_esreservado,bool p_escancelado,bool p_eseliminado,bool p_escomprado) { 
            Id = p_id;
            Nombre = p_nombre;
            Esactivo= p_esactivo;
            Esreservado= p_esreservado;
            Escancelado= p_escancelado;
            Eseliminado = p_eseliminado;
            Escomprado= p_escomprado;
        }
    }
}
