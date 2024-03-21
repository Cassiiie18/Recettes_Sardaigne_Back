using DAL.Entities;
using System;


namespace DAL.Interfaces
{
    public interface IRecetteRepository
    {
        public Recette CreateRecette(Recette recette);
      //  public bool DeleteRecette(Recette recette);
        //public bool UpdateRecette(Recette recette);
       // public Recette GetRecetteById(int ind_recette);
        public Recette GetRecetteByName(string nom);

        //public IEnumerable<Recette> GetAllRecettes();
    }
}
