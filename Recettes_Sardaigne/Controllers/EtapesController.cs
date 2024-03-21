using BLL.Forms;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Recettes_Sardaigne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtapesController : ControllerBase
    {
        private readonly EtapesService _etapesService;

        public EtapesController(EtapesService etapesService)
        {
            _etapesService = etapesService;
        }

        [HttpPost]
        public IActionResult CreateEtapes(EtapesForm etapesForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _etapesService.CreateEtapes(etapesForm);
            return Ok("Etape ajoutée");
        }
    }
}
