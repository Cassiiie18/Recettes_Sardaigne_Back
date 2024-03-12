using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRecetteRepository
    {
        public Recette CreateRecette(Recette recette);
        public bool DeleteRecette(Recette recette);
        public Recette UpdateRecette(Recette recette);
        public Recette GetRecetteById(int ind_recette);
        public Recette GetRecetteByName(string nom);

        public IEnumerable<Recette> GetAllRecettes();
    }
}
