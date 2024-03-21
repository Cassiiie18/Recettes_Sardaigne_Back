
namespace DAL.Mappers
{
    public static class TempsMapper
    {
        public static Temps ToTemps(this SqlDataReader reader)
        {
            return new Temps()
            {
                id_temps = (int)(reader["id_temps"]),
                temps_cuisson_minutes = (int)( reader["temps_cuisson_minutes"]), 
                temps_preparation_minutes = (int)(reader["temps_preparation_minutes"]),
                temps_total_minutes = (int)(reader["temps_total_minutes"]),
            };
        }



    }
}
