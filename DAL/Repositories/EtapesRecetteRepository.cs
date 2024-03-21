

namespace DAL.Repositories
{
    public class EtapesRecetteRepository : IEtapesRecetteRepository
    {
        private readonly string _connectionString;
        public EtapesRecetteRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void CreateEtapesRecette(int id_recette, int id_etapes)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = "INSERT INTO EtapesRecette (Id_recette, Id_Etapes) VALUES (@Id_recette, @Id_etapes)";


                    command.Parameters.AddWithValue("Id_recette", id_recette);
                    command.Parameters.AddWithValue("Id_etapes", id_etapes);
                    connection.Open();

                    command.ExecuteNonQuery();



                    connection.Close();

                    
                }
            }
        }

        public bool DeleteEtapesRecette(int id_recette)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EtapesRecette> GetAllEtapesRecettes()
        {
            List<EtapesRecette> etapesRecettes = new List<EtapesRecette>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = "SELECT * FROM EtapesRecette";

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        EtapesRecette etapesRecette = new EtapesRecette
                        {
                            Id_recette = Convert.ToInt32(reader["Id_recette"]),
                            Id_etapes = Convert.ToInt32(reader["Id_etapes"])
                        };

                        etapesRecettes.Add(etapesRecette);




                    }
                    return etapesRecettes;
                }
            }

        }

        public EtapesRecette GetEtapesRecetteById(int id_recette, int id_etapes)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {


                    command.CommandText = "SELECT * FROM EtapesRecette WHERE Id_recette = @Id_recette AND Id_etapes = @Id_etapes";

                    command.Parameters.AddWithValue("Id_recette", id_recette);
                    command.Parameters.AddWithValue("Id_etapes", id_etapes);


                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();


                    EtapesRecette er = null;


                    while (reader.Read())
                    {
                        er = reader.ToEtapesRecette();


                    }

                    connection.Close();

                    return er;

                }
            }
        }

        public EtapesRecette GetEtapesRecetteByName(string nom)
        {
            throw new NotImplementedException();
        }
    }
}
