using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class EtapesRecetteMapper
    {
        public static EtapesRecette ToEtapesRecette(this SqlDataReader reader)
        {
            return new EtapesRecette
            {
                Id_etapes = (int)(reader["id_etapes"]),
                recette = (Recette)(reader["recette"]),
                etapes = (Etapes)(reader["etapes"]),
                Id_recette = (int)(reader["id_recette"]),
                
            };
        }
    }
}
