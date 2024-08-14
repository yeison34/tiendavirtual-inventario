using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Negocio.Utilidades
{
    public partial class RutasNegocio
    {

        public static string ObtenerRutaRelativa(){
            var ruta = ConfigurationManager.AppSettings["Url"];
            return ruta;
        }
    }
}
