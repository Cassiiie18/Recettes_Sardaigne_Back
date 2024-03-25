

using DAL.Entities;

namespace DAL.Repositories
{
    public class EtapesRecetteRepository : IEtapesRecetteRepository
    {
        private readonly string _connectionString;
        public EtapesRecetteRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region GetAll

        public IEnumerable<EtapesRecette> GetAllEtapesRecettes(int id)
        {
            List<EtapesRecette> etapesRecettes = new List<EtapesRecette>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = "SELECT * FROM Recette WHERE Id_recette = id";


                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();



                    while (reader.Read())
                    {
                        etapesRecettes.Add(reader.ToEtapesRecette());
                    }

                    connection.Close();


                    return etapesRecettes;
                }


            }

        }
        #endregion

        #region GetById

        public EtapesRecette GetEtapesRecetteById(int id_recette)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {


                    command.CommandText = "SELECT * FROM Etapes WHERE Id = @Id_recette";

                    command.Parameters.AddWithValue("Id", id_recette);


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
        #endregion

        #region GetByName
        public EtapesRecette GetEtapesRecetteByName(string nom)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Recette WHERE nom = @nom";

                    command.Parameters.AddWithValue("Nom", nom);

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
        #endregion
    }
}

