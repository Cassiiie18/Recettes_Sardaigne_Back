using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Recette
    {
        public int id_recette;
        public string nom;
        public int nombre_personnes;
        public string photo;
        public string gamme_prix;
        public string difficulte;

        public Recette(int id_recette, string nom, int nombre_personnes, string photo)
        {
            this.id_recette = id_recette;
            this.nom = nom;
            this.nombre_personnes = nombre_personnes;
            this.photo = photo;
        }

        public Recette() { }
    }
}
