//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Everything.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using Validations;

    [System.ComponentModel.DataAnnotations.MetadataType(typeof(ProductoValidation))]
    public partial class producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public producto()
        {
            this.orden_detalle = new HashSet<orden_detalle>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string cantidad { get; set; }
        public string precio { get; set; }
        public string etiquetas { get; set; }
        public int tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orden_detalle> orden_detalle { get; set; }
        public virtual tipo tipo1 { get; set; }
    }
}