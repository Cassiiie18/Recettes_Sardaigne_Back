using BLL.Forms;
using BLL.Services;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Recettes_Sardaigne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecetteController : ControllerBase
    {
        private readonly RecetteService _recetteService;

        public RecetteController(RecetteService recetteService)
        {
            _recetteService = recetteService;
        }


        [HttpPost]
        public IActionResult CreateRecette(RecetteForm recetteForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _recetteService.CreateRecette(recetteForm);
            return Ok("Recette créée");
        }



        #region Autres


        //[HttpGet]
        //public IActionResult GetAllRecettes()
        //{

        //    List<Recette> recettes = _recetteService.GetAllRecettes().ToList();
        //    return Ok(recettes);
        //}

        //[HttpGet("{id_recette}")]
        //public IActionResult GetRecetteById(int id_recette)
        //{
        //    var tutu = _recetteService.GetRecetteById(id_recette);

        //    return Ok(tutu);
        //}

        //[HttpDelete("{id_recette}")]
        //public IActionResult DeleteRecette(int id_recette)
        //{
        //    _recetteService.DeleteRecette(id_recette);
        //    return Ok();
        //}

        //[HttpPatch]
        //public IActionResult UpdateRecette(string nom, UpdateRecetteForm updateRecetteForm)
        //{
        //    if (!ModelState.IsValid) return BadRequest();

        //    updateRecetteForm.nom = nom;
        //    _recetteService.UpdateRecette(updateRecetteForm);
        //    return Ok("Mise à jour effectuée");
        //}

        #endregion



        //[HttpGet("/nom/{nom}")]
        //public IActionResult GetRecetteByName(string nom)
        //{
        //    return Ok(_recetteService.GetRecetteByName(nom));
        //}


    }
}
