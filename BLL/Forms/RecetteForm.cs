

namespace BLL.Forms
{
    public class RecetteForm
    {
        [Required]
        public string nom {  get; set; }

        [Required]
        public int nombre_personnes {  get; set; }

        [Required]
        public string photo {  get; set; }


        [Required]
        public string gamme_prix { get; set; }


        [Required]
        public string difficulte { get; set; }

        [Required]
        public Temps temps { get; set; }

    }
}
