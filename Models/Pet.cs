using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HUELLAS_PNT1.Models
{
    public class Pet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        public String Name { get; set; }
        [Display(Name = "Edad")]
        public int Age { get; set; }
        [Display(Name = "Tipo de Mascota")]
        [EnumDataType(typeof(Type))]
        public Type Type { get; set; }
        [Display(Name = "Tamaño")]
        [EnumDataType(typeof(Size))]
        public Size Size { get; set; }
        [Display(Name = "Sexo")]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }
        [Display(Name = "Vacunado")]
        public Boolean Vaccinated { get; set; }
        [Display(Name = "Castrado")]
        public Boolean Castrated { get; set; }
        [Display(Name = "Descripción")]
        public String Description { get; set; }

    }
}
