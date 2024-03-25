using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CategorieRecetteRepository
    {
        private readonly string _connectionString;
        public CategorieRecetteRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public CategorieRecette GetCategorieRecetteById(int id_recette)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {


                    command.CommandText = "SELECT * FROM Categorie WHERE Id = @id_recette";

                    command.Parameters.AddWithValue("Id", id_recette);


                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();


                    CategorieRecette cr = null;


                    while (reader.Read())
                    {
                        cr = reader.To();


                    }

                    connection.Close();

                    return rt;

                }
            }
        }
    }
}
