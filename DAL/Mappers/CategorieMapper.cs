using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class CategorieMapper
    {
        public static Categorie ToCategorie(this SqlDataReader reader)
        {
            return new Categorie
            {
                Id_categorie = (int)(reader["Id_categorie"]),
                Nom_categorie = (string)(reader["Nom_categorie"])
            };
        }
    }
}
