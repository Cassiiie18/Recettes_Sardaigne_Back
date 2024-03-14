using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class TempsMapper
    {
        public static Temps ToTemps(this SqlDataReader reader)
        {
            return new Temps()
            {
                id_temps = (int)(reader["id_temps"]),
                temps_cuisson = (TimeOnlyPerso)( reader["temps_cuisson"]), 
                temps_preparation = (TimeOnlyPerso)(reader["temps_preparation"]),
                temps_total = (TimeOnlyPerso)(reader["temps_total"]),
            };
        }

    }
}
