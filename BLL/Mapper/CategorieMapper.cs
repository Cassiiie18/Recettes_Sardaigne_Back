using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    public static class CategorieMapper
    {
        public static Categorie ToCategorie(this CategorieForm categorieForm)
        {
            return new Categorie
            {
                Nom_categorie = categorieForm.Nom_categorie
            };
        }
    }
}
