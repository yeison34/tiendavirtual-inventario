using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class Vistaproductoscategoria
    {
        public static string NombreTabla = "productos_vistaproductoscategoria";
        public int Id { get; set; }

        public static string IdCampo = "productos_vistaproductoscategoria.id";
        public string Codigo { get; set; }

        public static string CodigoCampo = "productos_vistaproductoscategoria.codigo";
        public string Nombre { get; set; }

        public static string NombreCampo = "productos_vistaproductoscategoria.nombre";
        public bool Estaactivo { get; set; }

        public static string EstaactivoCampo = "productos_vistaproductoscategoria.estaactivo";

        public Vistaproductoscategoria()
        {
        }

        public Vistaproductoscategoria(int p_id, string p_codigo, string p_nombre, bool p_estaactivo)
        {
            Id = p_id;
            Codigo = p_codigo;
            Nombre = p_nombre;
            Estaactivo = p_estaactivo;
        }
    }
}
