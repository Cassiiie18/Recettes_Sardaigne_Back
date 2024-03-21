

namespace BLL.Forms
{
    public class RecetteTempsForm
    {
        public string nom { get; set; }
        public int nombre_personnes { get; set; }
        public string photo { get; set; }
        public string gamme_prix { get; set; }
        public string difficulte { get; set; }

        public int temps_cuisson_minutes { get; set; }

        public int temps_preparation_minutes { get; set; }

        public int temps_total_minutes { get; set; }


        //public TimeOnlyPerso temps_cuisson { get; set; }

        //public TimeOnlyPerso temps_preparation { get; set; }

        //public TimeOnlyPerso temps_total { get; set; }
    }
}
