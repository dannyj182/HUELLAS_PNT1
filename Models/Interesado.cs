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
        public int IdMascota { get; set; }



        [Required(ErrorMessage = "Nombre y Apellido es requerido")]
        [Display(Name = "Nombre y Apellido")]
        public String NombreCompleto { get; set; }

        [Display(Name = "Teléfono")]

        [Required(ErrorMessage = "El Teléfono es requerido")]
        [RegularExpression(@"^[0-9,$]*$", ErrorMessage = "Formato de teléfono inválido")]
        public String Telefono { get; set; }

        [Required(ErrorMessage = "Email es requerido")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$",
        ErrorMessage = "Ingrese un formato de email válido")]
        [Display(Name = "Email")]
        public String Email { get; set; }


    }
}
