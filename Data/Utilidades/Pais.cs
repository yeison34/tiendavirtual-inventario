using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utilidades
{
    public partial class Pais
    {
        public static string NombreTabla = "utilidades_pais";

        public int Id { get; set; }

        public static string IdCampo = "utilidades_pais.id";

        public string Codigo { get; set; }

        public static string CodigoCampo = "utilidades_pais.codigo";

        public string Nombre { get; set; }

        public static string NombreCampo = "utilidades_pais.nombre";

        public bool Estaactivo { get; set; }

        public static string EstaactivoCampo = "utilidades_pais.estaactivo";

        public Pais() { }

        public Pais(int p_id,string p_codigo,string p_nombre,bool p_estaactivo) { 
            Id=p_id;
            Codigo=p_codigo;
            Nombre=p_nombre;
            Estaactivo=p_estaactivo;
        }
    }
}
