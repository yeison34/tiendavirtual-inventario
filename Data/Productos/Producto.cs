using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class Producto
    {
        public static string NombreTabla = "productos_producto";
        public int Id { get; set; }

        public static string IdCampo = "productos_producto.id";
        public string Codigo { get; set; }

        public static string CodigoCampo = "productos_producto.codigo";
        public string Nombre { get; set; }

        public static string NombreCampo = "productos_producto.nombre";
        public string Descripcion { get; set; }

        public static string DescripcionCampo = "productos_producto.descripcion";
        public string Codigoqr { get; set; }

        public static string CodigoqrCampo = "productos_producto.codigoqr";
        public string Referencia { get; set; }

        public static string ReferenciaCampo = "productos_producto.referencia";
        public string Peso { get; set; }

        public static string PesoCampo = "productos_producto.peso";
        public int? Idunidadmedida { get; set; }

        public static string IdunidadmedidaCampo = "productos_producto.idunidadmedida";

        public Unidadmedida Idunidadmedidaunidadmedida
        {
            get {
                return UnidadmedidaData.getPorId(Idunidadmedida??0);
            }
        }
        public decimal Preciocompra { get; set; }

        public static string PreciocompraCampo = "productos_producto.preciocompra";

        public int? Idcategoria { get; set; }

        public static string IdcategoriaCampo = "productos_producto.idcategoria";

        public Categoria Idcategoriacategoria
        {
            get {
                return CategoriaData.GetPorId(Idcategoria??0);
            }
        }

        public int? Idsubcategoria { get; set; }

        public static string IdsubcategoriaCampo = "productos_producto.idsubcategoria";

        public Subcategoria Idsubcategoriasubcategoria
        {
            get {
                return SubcategoriaData.getPorId(Idsubcategoria??0);
            }
        }
        public int Cantidadstock { get; set; }

        public static string CantidadstockCampo = "productos_producto.cantidadstock"; 
        public string Imagen { get; set; }

        public static string ImagenCampo = "productos_producto.imagen";
        public DateTime? Fechacreacion { get; set; }

        public static string FechacreacionCampo = "productos_producto.fechacreacion";
        public DateTime? Fechamodificacion { get; set; }

        public static string FechamodificacionCampo = "productos_producto.fechamodificacion";
        public bool Estaactivo { get; set; }

        public static string EstaactivoCampo = "productos_producto.estaactivo";
        public Producto(int p_id, string p_codigo, string p_nombre, string p_descripcion, string p_codigoqr, string p_referencia, string p_peso, int? p_idunidadmedida, decimal p_preciocompra, int? p_idcategoria, int? p_idsubcategoria,int p_cantidadstock, string p_imagen, DateTime? p_fechacreacion, DateTime? p_fechamodificacion, bool p_estaactivo)
        {
            Id = p_id;
            Codigo = p_codigo;
            Nombre = p_nombre;
            Descripcion = p_descripcion;
            Codigoqr = p_codigoqr;
            Referencia = p_referencia;
            Peso = p_peso;
            Idunidadmedida= p_idunidadmedida;
            Preciocompra = p_preciocompra;
            Idcategoria= p_idcategoria;
            Idsubcategoria = p_idsubcategoria;
            Cantidadstock = p_cantidadstock;
            Imagen = p_imagen;
            Fechacreacion = p_fechacreacion;
            Fechamodificacion = p_fechamodificacion;
            Estaactivo = p_estaactivo;
        }
        public Producto() { }
    }
}
