

namespace DAL.Entities
{
    public class EtapesRecette
    {
        public int Id_recette { get; set; }
        public int Id_etapes { get; set; }

        public string Description { get; set; }
        public Recette Recette { get; set; }

        public Etapes Etapes { get; set; }

    }
}
