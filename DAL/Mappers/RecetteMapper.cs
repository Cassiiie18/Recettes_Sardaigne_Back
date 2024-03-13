using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class RecetteMapper
    {
        public static Recette ToRecette(this SqlDataReader reader)
        {
            return new Recette
            {
                id_recette = (int)(reader["id_recette"]),
                nom = (string)(reader["nom"]),
                nombre_personnes = (int)(reader["nombre_personnes"]),
                photo = (string)(reader["photo"]),
                gamme_prix = (string)(reader["gamme_prix"]),
                difficulte = (string)(reader["difficulte"])
            };
        }
    }
}
