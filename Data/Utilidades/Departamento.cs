using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utilidades
{
    public partial class Departamento
    {
        public static string NombreTabla = "utilidades_departamento";

        public int Id { get; set; }

        public static string IdCampo = "utilidades_departamento.id";

        public string Codigo { get; set; }

        public static string CodigoCampo = "utilidades_departamento.codigo";

        public string Nombre { get; set; }

        public static string NombreCampo = "utilidades_departamento.nombre";

        public int? Idpais { get; set; }

        public static string IdpaisCampo = "utilidades_departamento.idpais";

        public Pais Idpaispais
        {
            get {
                return PaisData.GetPorId(Idpais??0);
            }
        }
        public bool Estaactivo { get; set; }

        public static string EstaactivoCampo = "utilidades_departamento.estaactivo";

        public Departamento() { }

        public Departamento(int p_id, string p_codigo, string p_nombre, int? p_idpais,bool p_estaactivo)
        {
            Id = p_id;
            Codigo = p_codigo;
            Nombre = p_nombre;
            Idpais = p_idpais;
            Estaactivo = p_estaactivo;
        }
    }
}
