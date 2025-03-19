using Data.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class Vistareservacionproducto
    {
        public static string NombreTabla = "productos_vistareservacionproducto";

        public int Id { get; set; }

        public static string Idcampo = "productos_vistareservacionproducto.id";

        public int? Idproducto { get; set; }

        public static string IdproductoCampo = "productos_vistareservacionproducto.idproducto";
        public DateTime Fechareservacion { get; set; }

        public static string FechareservacionCampo = "productos_vistareservacionproducto.fechareservacion";

        public int? Idusuario { get; set; }

        public static string IdusuarioCampo = "productos_vistareservacionproducto.idusuario";

        public int? Idestadoreservacionproducto { get; set; }

        public static string IdestadoreservacionproductoCampo = "productos_vistareservacionproducto.idestadoreservacionproducto";
        public int? Cantidad { get; set; }

        public static string CantidadCampo = "productos_vistareservacionproducto.cantidad";
        public string Estadoreservacionproducto { get; set; }

        public static string EstadoreservacionproductoCampo = "productos_vistareservacionproducto.estadoreservacionproducto";

        public bool Esreservado { get; set; }

        public static string EsreservadoCampo = "productos_vistareservacionproducto.esreservado";
        public bool Escancelado { get; set; }

        public static string EscanceladoCampo = "productos_vistareservacionproducto.escancelado";

        public bool Eseliminado { get; set; }

        public static string EseliminadoCampo = "productos_vistareservacionproducto.eseliminado";
        public bool Escomprado { get; set; }

        public static string EscompradoCampo = "productos_vistareservacionproducto.escomprado";
        public string Identificacion { get; set; }

        public static string IdentificacionCampo = "productos_vistareservacionproducto.identificacion";
        public string Nombrecliente { get; set; }

        public static string NombreclienteCampo = "productos_vistareservacionproducto.nombrecliente";
        public string Nombreproducto { get; set; }

        public static string NombreproductoCampo = "productos_vistareservacionproducto.nombreproducto";
        public string Descripcion { get; set; }

        public static string DescripcionCampo = "productos_vistareservacionproducto.descripcion";

        public string Descripcionproducto { get; set; }

        public static string DescripcionproductoCampo = "productos_vistareservacionproducto.descripcionproducto";
        public string Imagen { get; set; }

        public static string ImagenCampo = "productos_vistareservacionproducto.imagen";

        public decimal Preciocompra { get; set; }

        public static string PreciocompraCampo="productos_vistareservacionproducto.preciocompra";
        public Vistareservacionproducto() { }

        public Vistareservacionproducto(int p_id, int? p_idproducto, DateTime p_fechareservacion, int? p_idusuario, int? p_idestadoreservacionproducto, int p_cantidad,string p_estadoreservacionproducto, bool p_esreservado, bool p_escancelado, bool p_eseliminado, bool p_escomprado,string p_identificacion,string p_nombrecliente,string p_nombreproducto,string p_descripcion,string p_descripcionproducto,string p_imagen,decimal p_preciocompra) {
            Id = p_id;
            Idproducto = p_idproducto;
            Fechareservacion = p_fechareservacion;
            Idusuario = p_idusuario;
            Idestadoreservacionproducto = p_idestadoreservacionproducto;
            Cantidad = p_cantidad;
            Estadoreservacionproducto=p_estadoreservacionproducto;
            Esreservado = p_esreservado;
            Escancelado = p_escancelado;
            Eseliminado = p_eseliminado;
            Escomprado = p_escomprado;
            Identificacion= p_identificacion;
            Nombrecliente= p_nombrecliente;
            Nombreproducto= p_nombreproducto;
            Descripcion= p_descripcion;
            Descripcionproducto= p_descripcionproducto;
            Imagen= p_imagen;
            Preciocompra = p_preciocompra;
        }
    }
}
