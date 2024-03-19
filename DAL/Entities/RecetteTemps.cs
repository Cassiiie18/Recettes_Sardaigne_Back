using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class RecetteTemps
    {
        public int id_recette { get; set; }
        public string nom { get; set; }
        public int nombre_personnes { get; set; }
        public string photo { get; set; }
        public string gamme_prix { get; set; }
        public string difficulte { get; set; }



        public int id_temps { get; set; }

        public int temps_cuisson_minutes { get; set; }

        public int temps_preparation_minutes { get; set; }

        public int temps_total_minutes { get; set; }
    }
}
