using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly string _connectionString;

        public UsersRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region Create
        public Users CreateUsers(Users users)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Users OUTPUT inserted.Id_user VALUES (@Email, @Pseudo, @Mot_de_passe)";

                    command.Parameters.AddWithValue("Email", users.Email);
                    command.Parameters.AddWithValue("Pseudo", users.Pseudo);
                    command.Parameters.AddWithValue("Mot_de_passe", users.Mot_de_passe);

                    connection.Open();

                    users.Id_user = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    return users;
                }
            }
        }
        #endregion

        #region Delete
        public bool DeleteUsers(Users users)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Users WHERE Id_user = @Id_user";

                    command.Parameters.AddWithValue("Id_user", users.Id_user);

                    connection.Open();

                    int rowAffected = command.ExecuteNonQuery();

                    connection.Close();

                    return rowAffected == 1;
                }
            }
        }
        #endregion

        #region GetAll
        public IEnumerable<Users> GetAllUsers()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Users";

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    List<Users> users = new List<Users>();

                    while (reader.Read())
                    {
                        users.Add(reader.ToUser());
                    }

                    connection.Close();

                    return users;
                }
            }
        }
        #endregion

        #region GetByEmail
        public Users? GetUserByEmail(string Email)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Users WHERE Email = @Email";

                    command.Parameters.AddWithValue("Email", Email);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    Users? u = null;

                    while (reader.Read())
                    {
                        u = reader.ToUser();
                    }

                    connection.Close();

                    return u;
                }
            }
        }
        #endregion

        #region GetById
        public Users? GetUserById(int Id_user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Users WHERE Id_user = @Id_user";

                    command.Parameters.AddWithValue("Id_user", Id_user);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    Users? u = null;

                    while (reader.Read())
                    {
                        u = reader.ToUser();
                    }

                    connection.Close();

                    return u;
                }
            }
        }
        #endregion


        #region Update
        public bool UpdateUsers(Users users)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE Users SET Email = @Email, Pseudo = @Pseudo, Mot_de_passe = @Mot_de_passe WHERE Id_user = @Id_user";

                    command.Parameters.AddWithValue("Email", users.Email);
                    command.Parameters.AddWithValue("Pseudo", users.Pseudo);
                    command.Parameters.AddWithValue("Mot_de_passe", users.Mot_de_passe);
                    command.Parameters.AddWithValue("Id_user", users.Id_user);

                    connection.Open();

                    int rowAffected = command.ExecuteNonQuery();

                    connection.Close();

                    return rowAffected == 1;
                }
            }
        } 
        #endregion
    }
}
