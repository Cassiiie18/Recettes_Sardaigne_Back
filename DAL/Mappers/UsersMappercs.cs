using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class UsersMappercs
    {
        public static Users ToUser(this SqlDataReader reader)
        {
            return new Users
            {
                Id_user = (int)(reader["Id_user"]),
                Email = (string)(reader["Email"]),
                Pseudo = (string)(reader["Pseudo"]),
                Mot_de_passe = (string)(reader["Mot_de_passe"])
            };
        }
    }
}
