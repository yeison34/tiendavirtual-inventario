using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Productos
{
    public class ProductoscategoriaModel
    {
        public List<VistaproductosModel> listaProductos { get; set; }

        public List<VistaproductoscategoriaModel> listaCategorias { get; set; }
        public ProductoscategoriaModel() {
            listaProductos= new List<VistaproductosModel>();
            listaCategorias= new List<VistaproductoscategoriaModel>();
        }
    }
}
