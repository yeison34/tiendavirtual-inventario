using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities.Productos
{
    public class CategoriaModel
    {
        public int Id { get; set; }

        [Display(Name = "Codigo")]
        public string Codigo { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Estaactivo")]
        public bool Estaactivo { get; set; }

        public CategoriaModel() { 
        }

        public CategoriaModel(int p_id,string p_codigo,string p_nombre,bool p_estaactivo)
        {
            Id = p_id;
            Codigo = p_codigo;
            Nombre = p_nombre;
            Estaactivo= p_estaactivo;
        }
    }
}
