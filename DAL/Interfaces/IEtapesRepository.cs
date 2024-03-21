

namespace DAL.Interfaces
{
    public interface IEtapesRepository
    {
        public Etapes CreateEtapes(Etapes etapes);

        public List<Etapes> GetAllEtapes();

        public bool DeleteEtapes(Etapes etapes);


    }
}
