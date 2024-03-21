namespace DAL.Interfaces
{
    public interface IRecetteTempsRepository
    {
        public RecetteTemps GetRecetteTempsById(int id_recette);

        public RecetteTemps GetRecetteTempsByName(string nom);

        public bool DeleteRecetteTemps(RecetteTemps recetteTemps);

        public IEnumerable<RecetteTemps> GetAllRecettesTemps();

        public bool UpdateRecetteTemps(RecetteTemps recetteTemps);
    }
}
