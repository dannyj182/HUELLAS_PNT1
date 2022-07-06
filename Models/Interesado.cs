using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HUELLAS_PNT1.Models
{
    public class Interesado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

   
        public int Id { get; set; }
        
        [Required(ErrorMessage = "La mascota de interés es requerida")]
        [Display(Name = "Mascota de Interés")]
        public int IdMascota { get; set; }



        [Required(ErrorMessage = "Nombre y Apellido es requerido")]
        [Display(Name = "Nombre y Apellido")]
        public String NombreCompleto { get; set; }

        [Display(Name = "Teléfono")]

        [Required(ErrorMessage = "El Teléfono es requerido")]
        [RegularExpression(@"^(?:(?:00)?549?)?0?(?:11|[2368]\d)(?:(?=\d{0,2}15)\d{2})??\d{8}$", ErrorMessage = "Formato de teléfono inválido")]
        public String Telefono { get; set; }

        [Required(ErrorMessage = "Email es requerido")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$",
        ErrorMessage = "Ingrese un formato de email válido")]
        [Display(Name = "Email")]
        public String Email { get; set; }


    }
}
