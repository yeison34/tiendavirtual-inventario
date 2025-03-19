using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Entities.Usuarios
{
    public class ClienteModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El tipo de identificacion es campo obligatorio")]
        [Display(Name ="Tipo Identificación *")]
        public int? Idtipoidentificacion { get; set; }

        [Required(ErrorMessage ="La identificación es campo obligatorio")]
        [Display(Name ="Identificación *")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage ="El nombre es campo obligatorio")]
        [Display(Name = "Nombre *")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="El apellido es campo obligatorio")]
        [Display(Name ="Apellido *")]
        public string Apellido { get; set; }

        [Required(ErrorMessage ="El genero es campo obligatorio")]
        [Display(Name ="Genero *")]
        public int? Idgenero { get; set; }
        [Display(Name ="Fecha Nacimiento")]
        public DateTime? Fechanacimiento { get; set; }
        [Display(Name = "Pais Nacimiento")]
        public int? Idpais { get; set; }

        [Display(Name = "Departamento Nacimiento")]
        public int? Iddepartamento { get; set; }

        [Display(Name = "Municipio Nacimiento")]
        public int? Idmunicipio { get; set; }

        [Display(Name = "Usuario")]
        public int? Idusuario { get; set; }

        public List<SelectListItem> ListaTipoIdentificacion { get; set; }

        public List<SelectListItem> ListaGenero { get; set; }

        public List<SelectListItem> ListaPais { get; set; }

        public List<SelectListItem> ListaDepartamento { get; set; }

        public List<SelectListItem> ListaMunicipio { get; set; }
        public ClienteModel()
        {
            ListaTipoIdentificacion = new List<SelectListItem>();
            ListaGenero = new List<SelectListItem>();
            ListaPais = new List<SelectListItem>();
            ListaDepartamento=new List<SelectListItem>();
            ListaMunicipio=new List<SelectListItem>();
        }

        public ClienteModel(int p_id, int p_idtipoidentificacion, string p_identificacion, string p_nombre, string p_apellido, int? p_idgenero, DateTime? p_fechanacimiento, int? p_idpais, int? p_iddepartamento, int? p_idmunicipio, int? p_idusuario)
        {
            Id = p_id;
            Idtipoidentificacion = p_idtipoidentificacion;
            Identificacion = p_identificacion;
            Nombre = p_nombre;
            Apellido = p_apellido;
            Idgenero = p_idgenero;
            Fechanacimiento = p_fechanacimiento;
            Idpais = p_idpais;
            Iddepartamento = p_iddepartamento;
            Idmunicipio = p_idmunicipio;
            Idusuario = p_idusuario;
        }
    }
}
