using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Usuarios
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo usuario es obligatorio")]
        [MinLength(1,ErrorMessage ="Debe contener minimo un caracter")]
        [Display(Name = "Usuario")]
        public string Nombreusuario { get; set;}

        [Required(ErrorMessage = "El campo contraseña es obligatorio")]
        [MinLength(8, ErrorMessage = "Debe contener minimo 8 caracteres")]
        [Display(Name = "Contraseña")]
        public string Contrasena { get; set;}

        public bool Esactivo { get; set; }

        [Display(Name = "Correo Electronico")]
        public string Correo { get; set; }

        [Display(Name = "Confirmar Contraseña")]
        public string Passwordconfirm { get; set; }

        
        public UsuarioModel(int p_id,string p_nombreusuario,string p_contrasenaa, bool p_esactivo, string p_correo)
        {
            Id= p_id;
            Nombreusuario = p_nombreusuario;
            Contrasena = p_contrasenaa;
            Esactivo = p_esactivo;
            Correo = p_correo;
        }

        public UsuarioModel(int p_id, string p_nombreusuario, string p_contrasenaa, bool p_esactivo, string p_correo, string p_passwordconfirm)
        {
            Id = p_id;
            Nombreusuario = p_nombreusuario;
            Contrasena = p_contrasenaa;
            Esactivo = p_esactivo;
            Correo = p_correo;
            Passwordconfirm = p_passwordconfirm;
        }
        public UsuarioModel(){}

        
    }
}
