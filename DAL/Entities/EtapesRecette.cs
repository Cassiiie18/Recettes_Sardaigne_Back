

namespace DAL.Entities
{
    public class EtapesRecette
    {
        public int Id_recette { get; set; }
        public int Id_etapes { get; set; }

        public Recette? recette { get; set; }

        public Etapes? etapes { get; set; }

    }
}
