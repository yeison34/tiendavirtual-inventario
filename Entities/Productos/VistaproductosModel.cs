using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities.Productos
{
    public class VistaproductosModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Codigo")]
        public string Codigo { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Codigoqr")]
        public string Codigoqr { get; set; }

        [Display(Name = "Referencia")]
        public string Referencia { get; set; }

        [Display(Name = "Peso")]
        public string Peso { get; set; }

        [Display(Name = "idunidadmedida")]
        public int? Idunidadmedida { get; set; }

        [Display(Name = "Unidad Medida")]
        public string Unidadmedida { get; set; }

        [Display(Name = "Precio Compra")]
        public decimal Preciocompra { get; set; }

        [Display(Name = "idcategoria")]
        public int? Idcategoria { get; set; }

        [Display(Name = "Categoria")]
        public string Categoria { get; set; }

        [Display(Name = "idsubcategoria")]
        public int? Idsubcategoria { get; set; }

        [Display(Name = "Sub Categoria")]
        public string Subcategoria { get; set; }

        [Display(Name = "Cantidad Stoke")]
        public int Cantidadstock { get; set; }

        [Display(Name = "Imagen")]
        public string Imagen { get; set; }

        [Display(Name = "Fecha Creación")]
        public DateTime? Fechacreacion { get; set; }

        [Display(Name = "Fecha Modificación")]
        public DateTime? Fechamodificacion { get; set; }

        [Display(Name = "Activo")]
        public bool Estaactivo { get; set; }

        [Display(Name = "Porcentaje Utilidad")]
        public decimal Porcentajeutilidad { get; set; }

        [Display(Name = "Precio Venta")]
        public decimal Precioventa { get; set; }
        public VistaproductosModel(int p_id, string p_codigo, string p_nombre, string p_descripcion, string p_codigoqr, string p_referencia, string p_peso, int? p_idunidadmedida, string p_unidadmedida, decimal p_preciocompra, int? p_idcategoria, string p_categoria, int? p_idsubcategoria, string p_subcategoria, int p_cantidadstock, string p_imagen, DateTime? p_fechacreacion, DateTime? p_fechamodificacion, bool p_estaactivo, decimal p_porcentajeutilidad, decimal p_precioventa)
        {
            Id = p_id;
            Codigo = p_codigo;
            Nombre = p_nombre;
            Descripcion = p_descripcion;
            Codigoqr = p_codigoqr;
            Referencia = p_referencia;
            Peso = p_peso;
            Idunidadmedida = p_idunidadmedida;
            Unidadmedida = p_unidadmedida;
            Preciocompra = p_preciocompra;
            Idcategoria = p_idcategoria;
            Categoria = p_categoria;
            Idsubcategoria = p_idsubcategoria;
            Subcategoria = p_subcategoria;
            Cantidadstock = p_cantidadstock;
            Imagen = p_imagen;
            Fechacreacion = p_fechacreacion;
            Fechamodificacion = p_fechamodificacion;
            Estaactivo = p_estaactivo;
            Porcentajeutilidad = p_porcentajeutilidad;
            Precioventa = p_precioventa;
        }
        public VistaproductosModel() { }
    }
}
