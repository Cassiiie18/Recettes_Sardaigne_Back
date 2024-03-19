using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
