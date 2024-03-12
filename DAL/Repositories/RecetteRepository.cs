using DAL.Entities;
using DAL.Interfaces;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class RecetteRepository : IRecetteRepository
    {
        private readonly string _connectionString;
        public RecetteRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Recette CreateRecette(Recette recette)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRecette(Recette recette)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE * FROM Recette WHERE id_recette = @id_recette";

                    command.Parameters.AddWithValue("id_recette", recette.id_recette);

                    connection.Open();

                    int rowAffected = command.ExecuteNonQuery();

                    connection.Close();

                    return rowAffected == 1; 

                }
            }
        }

        public IEnumerable<Recette> GetAllRecettes()
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Recette";

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    List<Recette> recettes = new List<Recette>();

                    while (reader.Read())
                    {
                        recettes.Add(reader.ToRecette());
                    }

                    connection.Close();

                    return recettes;
                }
            }
        }

        public Recette GetRecetteById(int id_recette)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Recette WHERE id_recette = @id_recette";

                    command.Parameters.AddWithValue("id_recette", id_recette);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    Recette? r = null;

                    while (reader.Read())
                    {
                        r = reader.ToRecette();
                    }

                    connection.Close();

                    return r;
                }
            }
        }

        public Recette GetRecetteByName(string nom)
        {
            throw new NotImplementedException();
        }

        public Recette UpdateRecette(Recette recette)
        {
            throw new NotImplementedException();
        }
    }
}
