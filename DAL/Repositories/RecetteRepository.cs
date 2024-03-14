using DAL.Entities;
using DAL.Interfaces;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = "INSERT INTO Temps OUTPUT inserted.Id_temps VALUES (@Temps_cuisson, @Temps_preparation, @Temps_total);";

                    command.Parameters.AddWithValue("Temps_cuisson", (recette.temps.temps_cuisson.Hour * 60 + recette.temps.temps_cuisson.Minute));
                    command.Parameters.AddWithValue("Temps_preparation", (recette.temps.temps_preparation.Hour * 60 + recette.temps.temps_preparation.Minute));
                    command.Parameters.AddWithValue("Temps_total", (recette.temps.temps_total.Hour * 60 + recette.temps.temps_total.Minute));


                    connection.Open();

                    recette.temps.id_temps = Convert.ToInt32(command.ExecuteScalar());

                    connection.Close();


                    command.CommandText = "INSERT INTO Recette OUTPUT inserted.Id_recette VALUES (@Nom, @Nombre_personnes, @Photo, @Gamme_prix, @Difficulte, @Id_temps);";


                    command.Parameters.AddWithValue("Nom", recette.nom);
                    command.Parameters.AddWithValue("Nombre_personnes", recette.nombre_personnes);
                    command.Parameters.AddWithValue("Photo", recette.photo);
                    command.Parameters.AddWithValue("Gamme_prix", recette.gamme_prix);
                    command.Parameters.AddWithValue("Difficulte", recette.difficulte);
                    command.Parameters.AddWithValue("Id_temps", recette.temps.id_temps);



                    connection.Open();

                    recette.id_recette = Convert.ToInt32(command.ExecuteScalar());

                 

                    connection.Close();

                    return recette;
                }
            }
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
                    //command.CommandText = "SELECT * FROM Recette JOIN Temps ON Recette.Id_temps = Temps.Id_temps";
                    command.CommandText = "SELECT * FROM Recette FULL JOIN Temps ON Recette.id_temps = Temps.id_temps;";
                    
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
                    //command.CommandText = "SELECT * FROM Recette WHERE id_recette = @id_recette";

                    command.CommandText = "SELECT * FROM Recette JOIN Temps ON Recette.Id_temps = Temps.Id_temps WHERE Recette.Id_recette = @Id_recette";


                    command.Parameters.AddWithValue("Id_recette", id_recette);

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
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    //command.CommandText = "SELECT * FROM Recette WHERE nom = @nom";

                    command.CommandText = "SELECT * FROM Recette JOIN Temps ON Recette.Id_temps = Temps.Id_temps WHERE Nom = Nom";


                    command.Parameters.AddWithValue("Nom", nom);

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

        public bool UpdateRecette(Recette recette)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE Recette SET nom = @nom, nombre_personnes = @nombre_personnes, photo = @photo, gamme_prix = @gamme_prix, difficulte = @difficulte;";

                    command.Parameters.AddWithValue("nom", recette.nom);
                    command.Parameters.AddWithValue("nombre_personnes", recette.nombre_personnes);
                    command.Parameters.AddWithValue("photo", recette.photo);
                    command.Parameters.AddWithValue("Gamme_prix", recette.gamme_prix);
                    command.Parameters.AddWithValue("Difficulte", recette.difficulte);

                    connection.Open();

                    int rowAffected = command.ExecuteNonQuery();

                    connection.Close();

                    return rowAffected == 1; 
                }
            }
        }
    }
}
