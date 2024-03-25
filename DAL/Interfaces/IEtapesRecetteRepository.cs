

namespace DAL.Interfaces
{
    public interface IEtapesRecetteRepository
    {


        public IEnumerable<EtapesRecette> GetAllEtapesRecettes(int id);

        public EtapesRecette GetEtapesRecetteById(int id_recette);

        public EtapesRecette GetEtapesRecetteByName(string nom);
    }
}
