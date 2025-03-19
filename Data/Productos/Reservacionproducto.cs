using Data.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data.Productos
{
    public partial class Reservacionproducto
    {
        public static string NombreTabla = "productos_reservacionproducto";

        public int Id { get; set; }

        public static string Idcampo = "productos_reservacionproducto.id";

        public int? Idproducto { get; set; }

        public static string IdproductoCampo = "productos_reservacionproducto.idproducto";

        public Producto Idproductoproducto
        {
            get {
                return ProductoData.GetRegistroPorId(Idproducto??0);
            }
        }
        public DateTime Fechareservacion { get; set; }

        public static string FechareservacionCampo = "productos_reservacionproducto.fechareservacion";

        public int? Idusuario { get; set; }

        public static string IdusuarioCampo = "productos_reservacionproducto.idusuario";

        public Usuario Idusuariousuario
        {
            get {
                return UsuarioData.getRegistroPorId(Idusuario??0);
            }
        }
        public int? Idestadoreservacionproducto { get; set; }

        public static string IdestadoreservacionproductoCampo = "productos_reservacionproducto.idestadoreservacionproducto";
        
        public Estadoreservacionproducto Idestadoreservacionproductoestadoreservacionproducto
        {
            get {
                return EstadoreservacionproductoData.GetPorId(Idestadoreservacionproducto??0);
            }
        }

        public int? Cantidad { get; set; }

        public static string CantidadCampo = "productos_reservacionproducto.cantidad";


        public Reservacionproducto() { }

        public Reservacionproducto(int p_id,int? p_idproducto,DateTime p_fechareservacion,int? p_idusuario,int? p_idestadoreservacionproducto,int p_cantidad) {
            Id = p_id;
            Idproducto = p_idproducto;
            Fechareservacion = p_fechareservacion;
            Idusuario= p_idusuario;
            Idestadoreservacionproducto = p_idestadoreservacionproducto;
            Cantidad= p_cantidad;
        }
    }
}
