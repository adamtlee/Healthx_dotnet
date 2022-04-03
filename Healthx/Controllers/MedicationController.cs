using Healthx.Api.Models;
using Healthx.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Healthx.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicationController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Medication>> GetAll()
        {
            return StatusCode(200);
        } 

    }
}
