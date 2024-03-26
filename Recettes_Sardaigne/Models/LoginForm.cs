using System.ComponentModel.DataAnnotations;

namespace Recettes_Sardaigne.Models
{
    public class LoginForm
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Mot_de_passe { get; set; }

    }
}
