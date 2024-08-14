using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Productos
{
    public class SubcategoriaModel
    {

        public int Id { get; set; }

        [Display(Name ="Codigo")]
        public string Codigo { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Categoria")]
        public int? Idcategoria { get; set; }

        [Display(Name = "Estaactivo")]
        public bool Estaactivo { get; set; }

        [Display(Name = "Porcentaje Utilidad")]
        public decimal Porcentajeutilidad { get; set; }

        public SubcategoriaModel()
        {
        }

        public SubcategoriaModel(int p_id, string p_codigo, string p_nombre, int? p_idcategoria, bool p_estaactivo, decimal p_porcentajeutilidad)
        {
            Id = p_id;
            Codigo = p_codigo;
            Nombre = p_nombre;
            Idcategoria = p_idcategoria;
            Estaactivo = p_estaactivo;
            Porcentajeutilidad = p_porcentajeutilidad;
        }
    }
}
