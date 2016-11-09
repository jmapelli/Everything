using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Everything.Models.Validations
{
    public class ProductoValidation
    {
        [DisplayName("Código")]
        public int id { get; set; }

        [DisplayName("Nombre")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Por ingrese el nombre")]
        public string nombre { get; set; }

        [DisplayName("Descripción")]
        [MaxLength(500)]
        [Required(ErrorMessage = "Por ingrese la descripción")]
        public string descripcion { get; set; }

        [DisplayName("Cantidad")]
        [MaxLength(10)]
        [Required(ErrorMessage = "Por favor ingrese la cantidad")]
        public string cantidad { get; set; }

        [DisplayName("Precio")]
        [MaxLength(9)]
        [Required(ErrorMessage = "Por favor ingrese el precio")]
        public string precio { get; set; }

        [DisplayName("Tipo")]
        [Required(ErrorMessage = "Por favor ingrese el tipo")]
        public int tipo { get; set; }
    }
}