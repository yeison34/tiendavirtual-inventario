using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class Vistaproductos
    {
        public static string NombreTabla = "productos_vistaproductos";
        public int Id { get; set; }

        public static string IdCampo = "productos_vistaproductos.id";
        public string Codigo { get; set; }

        public static string CodigoCampo = "productos_vistaproductos.codigo";
        public string Nombre { get; set; }

        public static string NombreCampo = "productos_vistaproductos.nombre";
        public string Descripcion { get; set; }

        public static string DescripcionCampo = "productos_vistaproductos.descripcion";
        public string Codigoqr { get; set; }

        public static string CodigoqrCampo = "productos_vistaproductos.codigoqr";
        public string Referencia { get; set; }

        public static string ReferenciaCampo = "productos_vistaproductos.referencia";
        public string Peso { get; set; }

        public static string PesoCampo = "productos_vistaproductos.peso";
        public int? Idunidadmedida { get; set; }

        public static string IdunidadmedidaCampo = "productos_vistaproductos.idunidadmedida";
        public string Unidadmedida { get; set; }

        public static string UnidadmedidaCampo = "productos_vistaproductos.unidadmedida";
        public decimal Preciocompra { get; set; }

        public static string PreciocompraCampo = "productos_vistaproductos.preciocompra";

        public int? Idcategoria { get; set; }

        public static string IdcategoriaCampo = "productos_vistaproductos.idcategoria";
        public string Categoria { get; set; }

        public static string CategoriaCampo = "productos_vistaproductos.categoria";
        public int? Idsubcategoria { get; set; }

        public static string IdsubcategoriaCampo = "productos_vistaproductos.idsubcategoria";

        public string Subcategoria { get; set; }

        public static string SubcategoriaCampo = "productos_vistaproductos.subcategoria";
        public int Cantidadstock { get; set; }

        public static string CantidadstockCampo = "productos_vistaproductos.cantidadstock";
        public string Imagen { get; set; }

        public static string ImagenCampo = "productos_vistaproductos.imagen";
        public DateTime? Fechacreacion { get; set; }

        public static string FechacreacionCampo = "productos_vistaproductos.fechacreacion";
        public DateTime? Fechamodificacion { get; set; }

        public static string FechamodificacionCampo = "productos_vistaproductos.fechamodificacion";
        public bool Estaactivo { get; set; }

        public static string EstaactivoCampo = "productos_vistaproductos.estaactivo";

        public decimal Porcentajeutilidad { get; set; }

        public static string PorcentajeutilidadCampo = "productos_vistaproductos.porcentajeutilidad";
        public decimal Precioventa { get; set; }

        public static string PrecioventaCampo = "productos_vistaproductos.precioventa";
        public Vistaproductos(int p_id, string p_codigo, string p_nombre, string p_descripcion, string p_codigoqr, string p_referencia, string p_peso, int? p_idunidadmedida, string p_unidadmedida,decimal p_preciocompra, int? p_idcategoria, string p_categoria, int? p_idsubcategoria, string p_subcategoria, int p_cantidadstock, string p_imagen, DateTime? p_fechacreacion, DateTime? p_fechamodificacion, bool p_estaactivo, decimal p_porcentajeutilidad, decimal p_precioventa)
        {
            Id = p_id;
            Codigo = p_codigo;
            Nombre = p_nombre;
            Descripcion = p_descripcion;
            Codigoqr = p_codigoqr;
            Referencia = p_referencia;
            Peso = p_peso;
            Idunidadmedida = p_idunidadmedida;
            Unidadmedida= p_unidadmedida;
            Preciocompra = p_preciocompra;
            Idcategoria = p_idcategoria;
            Categoria= p_categoria;
            Idsubcategoria = p_idsubcategoria;
            Subcategoria= p_subcategoria;
            Cantidadstock = p_cantidadstock;
            Imagen = p_imagen;
            Fechacreacion = p_fechacreacion;
            Fechamodificacion = p_fechamodificacion;
            Estaactivo = p_estaactivo;
            Porcentajeutilidad = p_porcentajeutilidad;
            Precioventa = p_precioventa;
        }
        public Vistaproductos() { }
    }
}
