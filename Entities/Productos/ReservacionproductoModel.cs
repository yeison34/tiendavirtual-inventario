using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Productos
{
    public class ReservacionproductoModel
    {
        public int Id { get; set; }

        [Display(Name ="Producto")]
        public int? Idproducto { get; set; }

        [Display(Name = "Cantidad Reserva")]
        public int Cantidadreserva { get; set; }

        [Display(Name = "Fecha Reservacion")]
        public DateTime Fechareservacion { get; set; }
        public ReservacionproductoModel() { }

        public ReservacionproductoModel(int p_id, int? p_idproducto, int p_cantidadreserva, DateTime p_fechareservacion)
        {
            Id = p_id;
            Idproducto = p_idproducto;
            Cantidadreserva = p_cantidadreserva;
            Fechareservacion = p_fechareservacion;
        }
    }
}
