using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class RecetteTempsMapper
    {
        public static RecetteTemps ToRecetteTemps(this SqlDataReader reader)
        {
            return new RecetteTemps
            {
                id_recette = (int)(reader["id_recette"]),
                nom = (string)(reader["nom"]),
                nombre_personnes = (int)(reader["nombre_personnes"]),
                photo = (string)(reader["photo"]),
                gamme_prix = (string)(reader["gamme_prix"]),
                difficulte = (string)(reader["difficulte"]),
                id_temps = (int)(reader["id_temps"]),
                temps_cuisson_minutes = (int)(reader["temps_cuisson_minutes"]),
                temps_preparation_minutes = (int)(reader["temps_preparation_minutes"]),
                temps_total_minutes = (int)(reader["temps_total_minutes"]),

            };

        }
    }
}
