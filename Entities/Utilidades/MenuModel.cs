using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Utilidades
{
    public class MenuModel
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Controllername { get; set; }

        public string Actionname { get; set; }

        public int Idpadre { get; set; }

        public bool Estaactivo { get; set; }

        public MenuModel() { }

        public MenuModel(int id,string codigo,string nombre,string controllername,string actionname,int idpadre,bool estaactivo) {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Controllername = controllername;
            Actionname = actionname;
            Idpadre = idpadre;
            Estaactivo= estaactivo;
        }
    }
}
