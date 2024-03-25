using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICategorieRepository
    {
        public Categorie CreateCategorie(Categorie categorie);
        public IEnumerable<Categorie> GetAllCategories();

        public Categorie GetCategorieById(int id_categorie);

        public bool DeleteCategorie(Categorie categorie);
    }
}
