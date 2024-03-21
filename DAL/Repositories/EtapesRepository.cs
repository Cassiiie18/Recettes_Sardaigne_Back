

namespace DAL.Repositories
{
    public class EtapesRepository : IEtapesRepository
    {
        private readonly string _connectionString;
        public EtapesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Etapes CreateEtapes(Etapes etapes)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = "INSERT INTO Etapes OUTPUT inserted.Id_etapes VALUES (@Description);";


                    command.Parameters.AddWithValue("Description", etapes.Description);


                    connection.Open();

                    //etapes.Id_etapes = Convert.ToInt32(command.ExecuteScalar());
                    command.ExecuteNonQuery();



                    connection.Close();

                    return etapes;
                }
            }
        }

        public bool DeleteEtapes(Etapes etapes)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE * FROM Etapes WHERE Id_etapes = @Id_etapes";

                    command.Parameters.AddWithValue("Id_etapes", etapes.Id_etapes) ;

                    connection.Open();

                    int rowAffected = command.ExecuteNonQuery();

                    connection.Close();

                    return rowAffected == 1;

                }
            }
        }



        public List<Etapes> GetAllEtapes()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    
                    command.CommandText = "SELECT * FROM Etapes";

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    List<Etapes> etapes = new List<Etapes>();

                    while (reader.Read())
                    {
                        etapes.Add(reader.ToEtapes());
                    }

                    connection.Close();


                    return etapes;
                }
            }
        }
    }
}
