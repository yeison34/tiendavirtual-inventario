using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Productos
{
    public class VistareservacionproductoModel
    {
        public int Id { get; set; }

        public int? Idproducto { get; set; }
        public DateTime Fechareservacion { get; set; }
        public int? Idusuario { get; set; }
        public int? Idestadoreservacionproducto { get; set; } public int? Cantidad { get; set; }
        public string Estadoreservacionproducto { get; set; }
        public bool Esreservado { get; set; }
        public bool Escancelado { get; set; }

        public bool Eseliminado { get; set; }
        public bool Escomprado { get; set; }
        public string Identificacion { get; set; }
        public string Nombrecliente { get; set; }

        public string Nombreproducto { get; set; }
        public string Descripcion { get; set; }

        public string Descripcionproducto { get; set; }
        public string Imagen { get; set; }

        public decimal Preciocompra { get; set; }
        public VistareservacionproductoModel() { }

        public VistareservacionproductoModel(int p_id, int? p_idproducto, DateTime p_fechareservacion, int? p_idusuario, int? p_idestadoreservacionproducto, int p_cantidad, string p_estadoreservacionproducto, bool p_esreservado, bool p_escancelado, bool p_eseliminado, bool p_escomprado, string p_identificacion, string p_nombrecliente, string p_nombreproducto, string p_descripcion, string p_descripcionproducto, string p_imagen, decimal p_preciocompra)
        {
            Id = p_id;
            Idproducto = p_idproducto;
            Fechareservacion = p_fechareservacion;
            Idusuario = p_idusuario;
            Idestadoreservacionproducto = p_idestadoreservacionproducto;
            Cantidad = p_cantidad;
            Estadoreservacionproducto = p_estadoreservacionproducto;
            Esreservado = p_esreservado;
            Escancelado = p_escancelado;
            Eseliminado = p_eseliminado;
            Escomprado = p_escomprado;
            Identificacion = p_identificacion;
            Nombrecliente = p_nombrecliente;
            Nombreproducto = p_nombreproducto;
            Descripcion = p_descripcion;
            Descripcionproducto = p_descripcionproducto;
            Imagen = p_imagen;
            Preciocompra= p_preciocompra;
        }
    }
}
