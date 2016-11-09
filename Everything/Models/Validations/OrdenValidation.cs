using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Everything.Models.Validations
{
    public class OrdenValidation
    {
        [DisplayName("Fecha evento")]
        [MaxLength(20)]
        [Required(ErrorMessage = "Por ingrese la fecha de evento")]
        public string delivery_fecha { get; set; }

        [DisplayName("Lugar evento")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Por ingrese el lugar de evento")]
        public string delivery_dir { get; set; }
    }
}