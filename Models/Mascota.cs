using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUELLAS_PNT1.Models
{
    public class Mascota
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Nombre { get; set; }
        [Display(Name = "Edad")]
        public int Edad { get; set; }
        [Display(Name = "Tipo de Mascota")]
        [EnumDataType(typeof(Tipo))]
        public Tipo Tipo { get; set; }
        [Display(Name = "Tamaño")]
        [EnumDataType(typeof(Tamanio))]
        public Tamanio Tamanio { get; set; }
        [Display(Name = "Sexo")]
        [EnumDataType(typeof(Genero))]
        public Genero Genero { get; set; }
        [Display(Name = "Vacunado")]
        public Boolean Vacunado { get; set; }
        [Display(Name = "Castrado")]
        public Boolean Castrado { get; set; }
        [Display(Name = "Descripción")]
        public String Descripcion { get; set; }

    }
}
