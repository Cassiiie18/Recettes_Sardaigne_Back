using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Forms
{
    public class UpdatePasswordForm
    {
        public int Id_User {  get; set; }

        public string VieuxMotDePasse { get; set; }

        [Required]
        [MaxLength(32)]
        [MinLength(1)]
        public string Mot_de_passe { get; set; }

        [Compare("Mot_de_passe")]
        public string ConfirmationMotDePasse { get; set; }
        
    }
}
