using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Forms
{
    public class UsersForm
    {
        [EmailAddress]
        [Required]
        [MaxLength(32)]
        public string Email { get; set; }

        [Required]
        [MaxLength(32)]
        [MinLength(3)]
        public string Pseudo {  get; set; }

        [Required]
        [MaxLength(32)]
        [MinLength(1)]
        public string Mot_de_passe { get; set; }


        [Compare("Mot_de_passe")]
        public string ConfirmationMotDePasse { get; set; }

    }
}
