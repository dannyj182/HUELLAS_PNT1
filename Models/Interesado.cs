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
        [Display(Name = "Nombre y Apellido")]
        public String NombreCompleto { get; set; }

        [Display(Name = "Teléfono")]
        public int Telefono { get; set; }

        [Display(Name = "Email")]
        public String Email { get; set; }
        [Display(Name = "Mascota de Interés")]
        public String MascotaDeInteres { get; set; }


    }
}
