using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HUELLAS_PNT1.Models
{
    public class UserViewModel
    {
        public string UserId { get; set; }
        [Display(Name = "Usuario")]
        public string UserName { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "El Mail es requerido")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$",
        ErrorMessage = "Ingrese un formato de email válido")]
        public string Email { get; set; }

        [Display(Name = "Contraseña Actual")]
        [Required(ErrorMessage = "La contraseña es requerida")]
        public string CurrentPassword { get; set; }

        [Display(Name = "Nueva Contraseña")]
        [Required(ErrorMessage = "La contraseña nueva")]
        public string NewPassword { get; set; }


    }
}
