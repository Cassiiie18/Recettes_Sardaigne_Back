using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUsersRepository
    {
        public Users CreateUsers(Users users);

        public bool DeleteUsers(Users users);
        public Users GetUserById(int Id_user); 

        public Users GetUserByEmail(string Email);

        public IEnumerable<Users> GetAllUsers();

        public bool UpdateUsers(Users users); 
    }
}
