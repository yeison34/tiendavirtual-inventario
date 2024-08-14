using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Usuario
{
    public class LoginModel
    {
        [Required(ErrorMessage ="El campo usuario es obligatorio")]
        [MinLength(1,ErrorMessage ="Debe contener minimo un caracter")]
        [Display(Name = "Usuario")]
        public string UserName { get; set;}

        [Required(ErrorMessage = "El campo contraseña es obligatorio")]
        [MinLength(8, ErrorMessage = "Debe contener minimo 8 caracteres")]
        [Display(Name = "Contraseña")]
        public string Password { get; set;}

        public LoginModel(string username,string password) {
            UserName= username;
            Password= password;
        }
        public LoginModel(){}

        
    }
}
