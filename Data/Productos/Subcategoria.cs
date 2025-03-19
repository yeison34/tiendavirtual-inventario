using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class Subcategoria
    {
        public static string NombreTabla = "productos_subcategoria";

        public int Id { get; set; }

        public static string IdCampo = "productos_subcategoria.id";
        public string Codigo { get; set; }

        public static string CodigoCampo = "productos_subcategoria.codigo";
        public string Nombre { get; set; }

        public static string NombreCampo = "productos_subcategoria.nombre";

        public int? Idcategoria { get; set; }

        public static string IdcategoriaCampo = "productos_subcategoria.idcategoria";
        
        public Categoria Idcategoriacategoria
        {
            get
            {
                return CategoriaData.GetPorId(Idcategoria??0);
            }
        }

        public bool Estaactivo { get; set; }

        public static string EstaactivoCampo = "productos_subcategoria.estaactivo";

        public decimal Porcentajeutilidad { get; set; }

        public static string PorcentajeutilidadCampo = "productos_subcategoria.porcentajeutilidad";
        public Subcategoria()
        {
        }

        public Subcategoria(int p_id, string p_codigo, string p_nombre, bool p_estaactivo,decimal p_porcentajeutilidad)
        {
            Id = p_id;
            Codigo = p_codigo;
            Nombre = p_nombre;
            Estaactivo = p_estaactivo;
            Porcentajeutilidad = p_porcentajeutilidad;
        }
    }
}
