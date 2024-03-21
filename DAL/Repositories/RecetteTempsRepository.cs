namespace DAL.Repositories
{
    public class RecetteTempsRepository : IRecetteTempsRepository
    {
        private readonly string _connectionString;
        public RecetteTempsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool DeleteRecetteTemps(RecetteTemps recetteTemps)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    //command.CommandText = "DELETE FROM RecetteTemps WHERE id_recette = @id_recette";
                    //command.CommandText = "DELETE FROM Recette WHERE Recette.id_recette = @id_recette;" +
                    //    "DELETE FROM Temps WHERE id_recette = @id_recette;";


                    // command.CommandText = "DELETE FROM Recette INNER JOIN Temps ON Recette.Id_temps = Temps.Id_temps WHERE Recette.Id_recette = @Id_recette";
                    command.CommandText = "DELETE FROM Recette WHERE Recette.Id_recette = @Id_recette;";


                    command.Parameters.AddWithValue("id_recette", recetteTemps.id_recette);

                    connection.Open();

                    int rowAffected = command.ExecuteNonQuery();

                    connection.Close();

                    return rowAffected == 1;




                }
            }
        }

        public IEnumerable<RecetteTemps> GetAllRecettesTemps()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Recette JOIN Temps ON Recette.Id_temps = Temps.Id_temps";
                    

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    List<RecetteTemps> recettesTemps = new List<RecetteTemps>();

                    while (reader.Read())
                    {
                        recettesTemps.Add(reader.ToRecetteTemps());
                    }

                    connection.Close();


                    return recettesTemps;
                }
            }
        }

        public RecetteTemps GetRecetteTempsById(int id_recette)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {


                    command.CommandText = "SELECT * FROM Recette JOIN Temps ON Recette.Id_temps = Temps.Id_temps WHERE Recette.Id_recette = @Id_recette";

                    command.Parameters.AddWithValue("Id_recette", id_recette);


                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();


                    RecetteTemps rt = null;


                    while (reader.Read())
                    {
                        rt = reader.ToRecetteTemps();


                    }

                    connection.Close();

                    return rt;

                }
            }
        }


        public RecetteTemps GetRecetteTempsByName(string nom)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    //command.CommandText = "SELECT * FROM Recette WHERE nom = @nom";

                    command.CommandText = "SELECT * FROM Recette JOIN Temps ON Recette.Id_temps = Temps.Id_temps WHERE Nom = Nom";


                    command.Parameters.AddWithValue("Nom", nom);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    RecetteTemps? rt = null;

                    while (reader.Read())
                    {
                        rt = reader.ToRecetteTemps();
                    }
                    connection.Close();
                    return rt;
                }
            }
        }

        public bool UpdateRecetteTemps(RecetteTemps recetteTemps)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE RecetteTemps SET nom = @nom, nombre_personnes = @nombre_personnes, photo = @photo, gamme_prix = @gamme_prix, difficulte = @difficulte, temps_cuisson = @temps_cuisson, temps_preparation = @temps_preparation, temps_total = @temps_total;";

                    command.Parameters.AddWithValue("nom", recetteTemps.nom);
                    command.Parameters.AddWithValue("nombre_personnes", recetteTemps.nombre_personnes);
                    command.Parameters.AddWithValue("photo", recetteTemps.photo);
                    command.Parameters.AddWithValue("gamme_prix", recetteTemps.gamme_prix);
                    command.Parameters.AddWithValue("difficulte", recetteTemps.difficulte);
                    command.Parameters.AddWithValue("temps_cuisson_minutes", recetteTemps.temps_cuisson_minutes);
                    command.Parameters.AddWithValue("temps_preparation_minutes", recetteTemps.temps_preparation_minutes);
                    command.Parameters.AddWithValue("temps_total_minutes", recetteTemps.temps_total_minutes);


                    connection.Open();

                    int rowAffected = command.ExecuteNonQuery();

                    connection.Close();

                    return rowAffected == 1;
                }
            }
        }
    }

}
