using BLL.Forms;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Recettes_Sardaigne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempsController : ControllerBase
    {
        private readonly TempsService _tempsService;

        public TempsController(TempsService tempsService)
        {
            _tempsService = tempsService;
        }


        //[HttpPost]
        //public IActionResult CreateTemps(TempsForm tempsForm)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest();
        //    }
        //    _tempsService.CreateTemps(tempsForm);
        //    return Ok("Temps ajouté");
        //}


        //[HttpGet("{id_temps}")]
        //public IActionResult GetTempsById(int id_temps)
        //{
        //    return Ok(_tempsService.GetTempsById(id_temps));
        //}


        //[HttpDelete("{id_temps}")]
        //public IActionResult DeleteRecette(int id_temps)
        //{
        //    _tempsService.DeleteTemps(id_temps);
        //    return Ok();
        //}

        //[HttpPatch]
        //public IActionResult UpdateTemps(int id_temps, UpdateTempsForm updateTempsForm)
        //{
        //    if (!ModelState.IsValid) return BadRequest();

        //    updateTempsForm.id_temps = id_temps;
        //    _tempsService.UpdateTemps(updateTempsForm);
        //    return Ok("Mise à jour effectuée");
        //}
    }
}
