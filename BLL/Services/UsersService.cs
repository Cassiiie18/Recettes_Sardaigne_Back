using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UsersService
    {
        private IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        #region Create
        public Users? CreateUsers(UsersForm usersForm)
        {
            Users? u = _usersRepository.GetUserByEmail(usersForm.Email);

            if (u == null)
            {
                Users users = usersForm.ToUser();

                //installer package BCrypt.Net-Next
                users.Mot_de_passe = BCrypt.Net.BCrypt.HashPassword(usersForm.Mot_de_passe);
                users = _usersRepository.CreateUsers(users);
                return users;

            }
            return null;
        }
        #endregion


        #region MailDejaUtilise
        public bool EmailDejaUtilise(string Email)
        {
            return _usersRepository.GetUserByEmail(Email) != null;
        }
        #endregion

        #region GetById
        public Users? GetUserById(int Id_user)
        {
            return _usersRepository.GetUserById(Id_user);
        }
        #endregion

        #region GetAll
        public IEnumerable<Users> GetAllUsers()
        {
            return _usersRepository.GetAllUsers();
        }
        #endregion

        #region UpdateMotDePasse
        public bool UpdateMotDePasse(UpdatePasswordForm form)
        {
            Users? u = _usersRepository.GetUserById(form.Id_User);

            if (u != null)
            {
                if (BCrypt.Net.BCrypt.Verify(form.VieuxMotDePasse, u.Mot_de_passe))
                {
                    u.Mot_de_passe = BCrypt.Net.BCrypt.HashPassword(form.Mot_de_passe);
                    return _usersRepository.UpdateUsers(u);
                }
            }

            return false;
        }
        #endregion


        #region Delete
        public bool DeleteUsers(int Id_user)
        {
            Users? u = _usersRepository.GetUserById(Id_user);

            if (u is not null)
            {
                return _usersRepository.DeleteUsers(u);
            }
            return false;
        }
        #endregion

        #region GetByEmail
        public Users? GetUserByEmail(string Email)
        {
            return _usersRepository.GetUserByEmail(Email);
        }
        #endregion


        #region Login
        public Users? Login(string Email, string Mot_de_passe)
        {
            Users u = _usersRepository.GetUserByEmail(Email);
            if (BCrypt.Net.BCrypt.Verify(Mot_de_passe, u.Mot_de_passe))
            {
                return u;
            }

            return null;
        } 
        #endregion





    }
}
