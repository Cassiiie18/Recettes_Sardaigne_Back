using BLL.Forms;
using BLL.Services;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recettes_Sardaigne.Models;
using Recettes_Sardaigne.Tools;

namespace Recettes_Sardaigne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersService _usersService;
        public UsersController(UsersService usersService)
        {
            _usersService = usersService;
        }

        #region POST Create
        [HttpPost]
        public IActionResult CreateUsers(UsersForm usersForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _usersService.CreateUsers(usersForm);
            return Ok("Profil créé");
        }
        #endregion

        #region POST Login
        [HttpPost("login")]
        public IActionResult Login(LoginForm loginForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Users connectedUser = _usersService.Login(loginForm.Email, loginForm.Mot_de_passe);

            if (connectedUser == null)
            {
                return BadRequest("Utilisateur inexistant");
            }

            TokenManager manager = new TokenManager();

            return Ok(manager.GenerateToken(connectedUser));
        }
        #endregion

        #region PATCH UpdateMotDePasse
        [HttpPatch("UpdateMotDePasse/{Id_user}")]
        public IActionResult UpdateMotDePasse([FromRoute] int Id_user, [FromBody] UpdatePasswordForm updateForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            updateForm.Id_User = Id_user;
            _usersService.UpdateMotDePasse(updateForm);
            return Ok("Mise à jour effectuée");
        }
        #endregion


        #region GET GetAll
        //[Authorize("adminPolicy")]
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_usersService.GetAllUsers());
        }
        #endregion


        #region GET GetById
        [HttpGet("{Id_user}")]
        public IActionResult GetUserById(int Id_user)
        {
            return Ok(_usersService.GetUserById(Id_user));
        }
        #endregion

        #region DELETE 
        //[Authorize("adminPolicy")]
        [HttpDelete("{Id_user}")]
        public IActionResult DeleteUsers(int Id_user)
        {
            _usersService.DeleteUsers(Id_user);
            return Ok();
        } 
        #endregion

    }
}
