using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utilidades
{
    public partial class Menu
    {
        public static string NombreTabla = "utilidades_menu";
        public int Id { get; set; }

        public static string IdCampo = "utilidades_menu.id";
        public string Codigo { get; set; }
         
        public static string CodigoCampo = "utilidades_menu.codigo";

        public string Nombre { get; set; }

        public static string NombreCampo = "utilidades_menu.nombre";

        public string Controllername { get; set; }

        public static string ControllernameCampo = "utilidades_menu.controllername";

        public string Actionname { get; set; }

        public static string ActionnameCampo = "utilidades_menu.actionname";

        public int? Idpadre { get; set; }

        public static string IdpadreCampo = "utilidades_menu.idpadre";
        public Menu Idpadremenu
        {
            get {
                return MenuData.getPorId(Idpadre??0);
            }
        }

        public bool Estaactivo { get; set; }

        public static string EstaactivoCampo = "utilidades_menu.estaactivo";
        public Menu() {        
        }

        public Menu(int id, string codigo, string nombre, string controllername, string actionname, int idpadre, bool estaactivo)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Controllername = controllername;
            Actionname = actionname;
            Idpadre = idpadre;
            Estaactivo = estaactivo;
        }
    }
}
