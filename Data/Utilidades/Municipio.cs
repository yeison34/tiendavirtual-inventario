using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utilidades
{
    public partial class Municipio
    {
        public static string NombreTabla = "utilidades_municipio";

        public int Id { get; set; }

        public static string IdCampo = "utilidades_municipio.id";

        public string Codigo { get; set; }

        public static string CodigoCampo = "utilidades_municipio.codigo";

        public string Nombre { get; set; }

        public static string NombreCampo = "utilidades_municipio.nombre";

        public int? Iddepartamento { get; set; }

        public static string IdIddepartamentoCampo = "utilidades_municipio.iddepartamento";

        public Departamento IdIddepartamentodepartamento
        {
            get
            {
                return DepartamentoData.GetPorId(Iddepartamento ?? 0);
            }
        }
        public bool Estaactivo { get; set; }

        public string EstaactivoCampo = "utilidades_municipio.estaactivo";

        public Municipio() { }

        public Municipio(int p_id, string p_codigo, string p_nombre, int? p_iddepartamento, bool p_estaactivo)
        {
            Id = p_id;
            Codigo = p_codigo;
            Nombre = p_nombre;
            Iddepartamento = p_iddepartamento;
            Estaactivo = p_estaactivo;
        }
    }
}
