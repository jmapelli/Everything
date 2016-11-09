using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Everything.Models.Validations
{
    public class UsuarioValidation
    {
        public int id { get; set; }

        [DisplayName("Nombres")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Por ingrese sus nombres")]
        public string nombres { get; set; }

        [DisplayName("Apellidos")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Por favor ingrese sus apellidos")]
        public string apellidos { get; set; }

        [DisplayName("Correo")]
        [MaxLength(100)]
        [EmailAddress(ErrorMessage = "Por favor ingrese su correo valido")]
        [Required(ErrorMessage = "Por favor ingrese su correo")]
        public string correo { get; set; }

        [DisplayName("Telefono")]
        [MaxLength(9)]
        [Required(ErrorMessage = "Por favor ingrese una contraseña")]
        public string telefeno { get; set; }

        [DisplayName("Contraseña")]
        [MaxLength(12)]
        [MinLength(6, ErrorMessage ="La contraseña debe contener mas de 6 carácteres")]
        [Required(ErrorMessage = "Por favor ingrese una contraseña")]
        public string contraseña { get; set; }
    }
}