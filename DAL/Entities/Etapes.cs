

namespace DAL.Entities
{
    public class Etapes
    {
        public int Id_etapes { get; set; }
        public string Description { get; set; }

       ///public List<EtapesRecette> Recettes { get; set; }

        public Recette recette { get; set; }
    }
}
