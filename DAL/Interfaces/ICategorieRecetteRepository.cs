using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICategorieRecetteRepository
    {
        public Categorie GetCategorieRecetteById(int id);
    }
}
