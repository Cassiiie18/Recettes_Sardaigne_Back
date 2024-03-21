using BLL.Services;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Recettes_Sardaigne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtapesRecetteController : ControllerBase
    {
        private readonly RecetteService _recetteService;
        private readonly EtapesRecetteService _etapesRecetteService;
        private readonly EtapesService _etapesService;

        public EtapesRecetteController(RecetteService recetteService, EtapesRecetteService etapesRecetteService, EtapesService etapesService)
        {
            _recetteService = recetteService;
            _etapesRecetteService = etapesRecetteService;
            _etapesService = etapesService;
        }

        [HttpGet]
        public IActionResult GetAllEtapesRecettes()
        {
            List<EtapesRecette> etapesRecette = _etapesRecetteService.GetAllEtapesRecettes().ToList();
            return Ok(etapesRecette);
        }

        [HttpGet("{id_recette}, {id_etapes} ")]
        public IActionResult GetEtapesRecetteById(int id_recette, int id_etapes)
        {
            var etapesR = _etapesRecetteService.GetEtapesRecetteById(id_recette, id_etapes);

            return Ok(etapesR);
        }









    }
}
