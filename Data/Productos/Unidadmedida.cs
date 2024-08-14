using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class Unidadmedida
    {
        public static string NombreTabla = "productos_unidadmedida";
        public int Id { get; set; }

        public static string IdCampo = "productos_unidadmedida.id";
        public string Codigo { get; set; }

        public static string CodigoCampo = "productos_unidadmedida.campo";
        public string Nombre { get; set; }

        public static string NombreCampo = "productos_unidadmedida.nombre";
        public int Cantidad { get; set; }

        public static string CantidadCampo = "productos_unidadmedida.cantidad";
        public bool Estaactivo { get; set; }

        public static string EstaactivoCampo = "productos_categoria.estaactivo";

        public Unidadmedida()
        {
        }

        public Unidadmedida(int p_id, string p_codigo, string p_nombre, int p_cantidad, bool p_estaactivo)
        {
            Id = p_id;
            Codigo = p_codigo;
            Nombre = p_nombre;
            Cantidad = p_cantidad;
            Estaactivo = p_estaactivo;
        }

    }
}
