

namespace DAL.Mappers
{
    public static class EtapesMapper
    {
        public static Etapes ToEtapes(this SqlDataReader reader)
        {
            return new Etapes
            {
                Id_etapes = (int)(reader["id_etapes"]),
                Description = (string)(reader["Description"]),

            };

        }
    }
}
