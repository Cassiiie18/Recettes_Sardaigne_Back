using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class RecetteRepository : IRecetteRepository
    {
        private readonly string _connectionString;
        public RecetteRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Recette CreateRecette(Recette recette)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRecette(Recette recette)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recette> GetAllRecettes()
        {
            throw new NotImplementedException();
        }

        public Recette GetRecetteById(int ind_recette)
        {
            throw new NotImplementedException();
        }

        public Recette GetRecetteByName(string nom)
        {
            throw new NotImplementedException();
        }

        public Recette UpdateRecette(Recette recette)
        {
            throw new NotImplementedException();
        }
    }
}
