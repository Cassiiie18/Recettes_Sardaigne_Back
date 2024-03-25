using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CategorieRepository : ICategorieRepository
    {
        private readonly string _connectionString;
        public CategorieRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region Create
        public Categorie CreateCategorie(Categorie categorie)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = "INSERT INTO Categorie OUTPUT inserted.Id_categorie VALUES (@Nom_categorie);";

                    command.Parameters.AddWithValue("Nom_categorie", categorie.Nom_categorie);


                    connection.Open();

                    categorie.Id_categorie = Convert.ToInt32(command.ExecuteScalar());

                    connection.Close();

                    return categorie;
                }
            }
        }
        #endregion

        #region Delete
        public bool DeleteCategorie(Categorie categorie)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetAll
        public IEnumerable<Categorie> GetAllCategories()
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = "SELECT * FROM Categorie";

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    List<Categorie> categorie = new List<Categorie>();

                    while (reader.Read())
                    {
                        categorie.Add(reader.ToCategorie());
                    }

                    connection.Close();


                    return categorie;
                }
            }

        }
        #endregion

        #region GetById
        public Categorie GetCategorieById(int id_categorie)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {


                    command.CommandText = "SELECT * FROM Categorie Id_categorie = @Id_categorie";

                    command.Parameters.AddWithValue("Id_categorie", id_categorie);


                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();


                    Categorie c = null;


                    while (reader.Read())
                    {
                        c = reader.ToCategorie();


                    }

                    connection.Close();

                    return c;
                }
            }
        } 
        #endregion
    }
}
