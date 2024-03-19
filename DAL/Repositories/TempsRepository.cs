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
    public class TempsRepository : ITempsRepository
    {
        private readonly string _connectionString;
        public TempsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        #region Autres

        //public Temps CreateTemps(Temps temps)
        //{
        //    using (SqlConnection connection = new SqlConnection(_connectionString))
        //    {
        //        using (SqlCommand command = connection.CreateCommand())
        //        {
        //            command.CommandText = "INSERT INTO Temps OUTPUT inserted.Id_temps VALUES (@temps_cuisson, @temps_preparation, @temps_total);";


        //            command.Parameters.AddWithValue("temps_cuisson", temps.temps_cuisson);
        //            command.Parameters.AddWithValue("temps_preparation", temps.temps_preparation);
        //            command.Parameters.AddWithValue("temps_total", temps.temps_total);

        //            connection.Open();

        //            temps.id_temps = Convert.ToInt32(command.ExecuteScalar());

        //            connection.Close();

        //            return temps;
        //        }
        //    }
        //}

        //public bool DeleteTemps(Temps temps)
        //{
        //    using (SqlConnection connection = new SqlConnection(_connectionString))
        //    {
        //        using (SqlCommand command = connection.CreateCommand())
        //        {
        //            command.CommandText = "DELETE * FROM Temps WHERE id_temps = @id_temps";

        //            command.Parameters.AddWithValue("id_temps", temps.id_temps);

        //            connection.Open();

        //            int rowAffected = command.ExecuteNonQuery();

        //            connection.Close();

        //            return rowAffected == 1;

        //        }
        //    }
        //}

        //public Temps GetTempsById(int id_temps)
        //{
        //    using (SqlConnection connection = new SqlConnection(_connectionString))
        //    {
        //        using (SqlCommand command = connection.CreateCommand())
        //        {
        //            command.CommandText = "SELECT * FROM Temps WHERE id_temps = @id_temps";

        //            command.Parameters.AddWithValue("id_temps", id_temps);

        //            connection.Open();

        //            SqlDataReader reader = command.ExecuteReader();

        //            Temps? t = null;

        //            while (reader.Read())
        //            {
        //                t = reader.ToTemps();
        //            }

        //            connection.Close();

        //            return t;
        //        }
        //    }
        //}

        //public bool UpdateTemps(Temps temps)
        //{
        //    using (SqlConnection connection = new SqlConnection(_connectionString))
        //    {
        //        using (SqlCommand command = connection.CreateCommand())
        //        {
        //            command.CommandText = "UPDATE Temps SET temps_cuisson = @temps_cuisson, temps_preparation = @temps_preparation, temps_total = @temps_total";

        //            command.Parameters.AddWithValue("temps_cuisson", temps.temps_cuisson);
        //            command.Parameters.AddWithValue("temps_preparation", temps.temps_preparation);
        //            command.Parameters.AddWithValue("temps_total", temps.temps_total);

        //            connection.Open();

        //            int rowAffected = command.ExecuteNonQuery();

        //            connection.Close();

        //            return rowAffected == 1;
        //        }
        //    }
        //}


        #endregion

    }
}

