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
        public string Email { get; set; }
    }
}
