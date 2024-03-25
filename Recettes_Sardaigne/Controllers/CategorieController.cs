using BLL.Forms;
using BLL.Services;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Recettes_Sardaigne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private readonly CategorieService _categorieService;

        public CategorieController(CategorieService categorieService)
        {
            _categorieService = categorieService;
        }

        [HttpPost]
        public IActionResult CreateCategorie(CategorieForm categorieForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _categorieService.CreateCategorie(categorieForm);
            return Ok("Categorie ajoutée");
        }


        [HttpGet]
        public IActionResult GetAllCategories()
        {
            List<Categorie> categories = _categorieService.GetAllCategories().ToList();
            return Ok(categories);
        }
    }
}
