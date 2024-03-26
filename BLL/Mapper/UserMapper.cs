using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    public static  class UserMapper
    {
        public static Users ToUser(this UsersForm usersForm)
        {
            return new Users
            {
                Email = usersForm.Email,
                Pseudo = usersForm.Pseudo,
                Mot_de_passe = usersForm.Mot_de_passe
            };
        }
    }
}
