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

        [Required(ErrorMessage = "El Nombre es requerido")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "La edad es requerida")]
        [Range (0,25, ErrorMessage = "La edad está fuera de rango")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El Tipo de mascota es requerido")]
        [Display(Name = "Tipo" )]
        [EnumDataType(typeof(Tipo))]
        public Tipo Tipo { get; set; }

        [Required(ErrorMessage = "El Tamaño de mascota es requerido")]
        [Display(Name = "Tamaño")]
        [EnumDataType(typeof(Tamanio))]
        public Tamanio Tamanio { get; set; }

        [Required(ErrorMessage = "El Sexo de la mascota es requerido")]
        [Display(Name = "Sexo")]
        [EnumDataType(typeof(Genero))]
        public Genero Genero { get; set; }

        [Display(Name = "Vacunado")]
        public Boolean Vacunado { get; set; }

  
        [Display(Name = "Castrado")]
        public Boolean Castrado { get; set; }

        [Required(ErrorMessage = "La imagen de la mascota es requerido")]
        [Display(Name = "Imagen")]
        [Url ( ErrorMessage="La dirección de URL es inválida")]
        [RegularExpression(".*(png|jpg|jpeg|gif)$",
        ErrorMessage = "Ingrese un formato de imagen gif, png, o jpeg")]
        public String Imagen { get; set; }

        [Display(Name = "Descripción")]
        public String Descripcion { get; set; }

    }
}
