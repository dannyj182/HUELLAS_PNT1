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
        public string NombreInteresado { get; set; }
        
        [Display(Name = "Teléfono")]
        public String TelInteresado { get; set; }
        [Display(Name = "Mail")]
        public String MailInteresado { get; set; }
        [Display(Name = "Nombre de Mascta")]
        public string NombreMascota { get; set; }
    }
}
