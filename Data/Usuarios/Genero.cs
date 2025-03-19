using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public partial class Genero
    {
        public static string NombreTabla = "usuarios_genero";
        public int Id { get; set; }

        public static string IdCampo = "usuarios_genero.id";

        public string Nombre { get; set; }

        public static string NombreCampo = "usuarios_genero.nombre";

        public bool Esmasculino { get; set; }

        public static string EsmasculinoCampo = "usuarios_genero.esmasculino";

        public bool Esfemenino { get; set; }

        public static string EsfemeninoCampo = "usuarios_genero.esfemenino";

        public bool Esotro { get; set; }

        public static string EsotroCampo = "usuarios_genero.esotro";

        public bool Esactivo { get; set; }

        public static string EsactivoCampo = "usuarios_genero.esactivo";

        public Genero() { }

        public Genero(int p_id,string p_nombre,bool p_esmasculino,bool p_esfemenino,bool p_esotro,bool p_esactivo) {
            Id = p_id;
            Nombre = p_nombre;
            Esmasculino = p_esmasculino;
            Esfemenino = p_esfemenino;
            Esotro = p_esotro;
            Esactivo = p_esactivo;
        }
    }
}
