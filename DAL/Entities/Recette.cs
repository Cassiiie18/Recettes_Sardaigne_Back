using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Serializable]
    public class Recette
    {
        public int id_recette {  get; set; }
        public string nom {  get; set; }
        public int nombre_personnes {  get; set; }
        public string photo {  get; set; }
        public string gamme_prix { get; set; }
        public string difficulte { get; set; }
        public Temps temps { get; set; }

        public Recette(int id_recette, string nom, int nombre_personnes, string photo, string gamme_prix, string difficulte, Temps temps)
        {
            this.id_recette = id_recette;
            this.nom = nom;
            this.nombre_personnes = nombre_personnes;
            this.photo = photo;
            this.gamme_prix = gamme_prix;
            this.difficulte = difficulte;
            this.temps = temps;
        }

        public Recette() { 
        
        }
    }
}
