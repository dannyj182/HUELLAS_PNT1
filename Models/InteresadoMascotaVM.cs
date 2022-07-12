using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HUELLAS_PNT1.Models
{
    public class InteresadoMascotaVM
    {
        public int IdInteresado { get; set; }

        [Display(Name = "Nombre y Apellido")]
        [Required(ErrorMessage = "El Nombre y Apellido es requerido")]
        public string NombreInteresado { get; set; }
        
        [Required(ErrorMessage = "El Teléfono es requerido")]
        [Display(Name = "Teléfono")]
        [RegularExpression(@"^(?:(?:00)?549?)?0?(?:11|[2368]\d)(?:(?=\d{0,2}15)\d{2})??\d{8}$", ErrorMessage = "Ingrese un formato de teléfono válido, ej: móvil 1125658932, fijo: 011459862315")]
        public String TelInteresado { get; set; }

        [Required(ErrorMessage = "El Mail es requerido")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$",
        ErrorMessage = "Ingrese un formato de email válido")]
        [Display(Name = "Mail")]
        public String MailInteresado { get; set; }
        
        [Display(Name = "Mascota")]
        [Required(ErrorMessage = "El Nombre de la mascota es requerido")]
        public string NombreMascota { get; set; }
    }
}
