using BLL.Services;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Recettes_Sardaigne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecetteTempsController : ControllerBase
    {
        private readonly RecetteTempsService _recetteTempsService;

        public RecetteTempsController(RecetteTempsService recetteTempsService)
        {
            _recetteTempsService = recetteTempsService;
        }

        [HttpGet]
        public IActionResult GetAllRecettesTemps()
        {

            List<RecetteTemps> recettesTemps = _recetteTempsService.GetAllRecettesTemps().ToList();
            return Ok(recettesTemps);
        }

        [HttpGet("{id_recette}")]
        public IActionResult GetRecetteTempsById(int id_recette)
        {
            var recetteT = _recetteTempsService.GetRecetteTempsById(id_recette);

            return Ok(recetteT);
        }

        [HttpDelete("{id_recette}")]
        public IActionResult DeleteRecetteTemps(int id_recette)
        {
            _recetteTempsService.DeleteRecetteTemps(id_recette);
            return Ok();
        }
    }
}
