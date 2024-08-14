using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Entities.Productos
{
    public class ProductoEditModel
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

        [Display(Name = "Unidad Medida")]
        public int? Idunidadmedida { get; set; }

        [Display(Name = "Precio Compra")]
        public decimal Preciocompra { get; set; }

        [Display(Name = "Categoria")]
        public int? Idcategoria { get; set; }

        [Display(Name = "Sub Categoria")]
        public int? Idsubcategoria { get; set; }

        [Display(Name = "Cantidad Stoke")]
        public int Cantidadstock { get; set; }

        [Display(Name = "Imagen")]

        public string Imagen {get;set;}
        public HttpPostedFileBase UploadImagen { get; set; }

        [Display(Name = "Fecha Creación")]
        public DateTime? Fechacreacion { get; set; }

        [Display(Name = "Fecha Modificación")]
        public DateTime? Fechamodificacion { get; set; }

        [Display(Name = "Activo")]
        public bool Estaactivo { get; set; }

        public List<SelectListItem> Categorias { get; set; }

        public List<SelectListItem> SubCategorias { get; set; }
        public List<SelectListItem> UnidadesMedida { get; set; }

        public ProductoEditModel(int p_id,string p_codigo,string p_nombre,string p_descripcion,string p_codigoqr,string p_referencia,string p_peso, int? p_idunidadmedida, decimal p_preciocompra, int? p_idcategoria, int? p_idsubcategoria,int p_cantidadstock,string p_imagen,DateTime? p_fechacreacion,DateTime? p_fechamodificacion,bool p_estaactivo) { 
            Id= p_id;   
            Codigo= p_codigo;
            Nombre= p_nombre;
            Descripcion= p_descripcion;
            Codigoqr= p_codigoqr;
            Referencia= p_referencia;
            Peso= p_peso;
            Idunidadmedida= p_idunidadmedida;
            Preciocompra= p_preciocompra;
            Idcategoria= p_idcategoria;
            Idsubcategoria= p_idsubcategoria;
            Cantidadstock= p_cantidadstock;
            Imagen= p_imagen;
            Fechacreacion= p_fechacreacion;
            Fechamodificacion = p_fechamodificacion;
            Estaactivo = p_estaactivo;
        }
        public ProductoEditModel() {
            Categorias=new List<SelectListItem>();  
            SubCategorias=new List<SelectListItem>();
            UnidadesMedida= new List<SelectListItem>(); 
        }
    }
}
