

namespace DAL.Interfaces
{
    public interface IEtapesRecetteRepository
    {
        public void CreateEtapesRecette(int id_recette, int id_etapes);

        public IEnumerable<EtapesRecette> GetAllEtapesRecettes();

        public bool DeleteEtapesRecette(int id_recette);

        public EtapesRecette GetEtapesRecetteById(int id_recette, int id_etapes);

        public EtapesRecette GetEtapesRecetteByName(string nom);
    }
}
