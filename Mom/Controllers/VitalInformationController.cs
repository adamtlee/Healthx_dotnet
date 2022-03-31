using Microsoft.AspNetCore.Mvc;
using Mom.Api.Models;
using Mom.Api.Services;

namespace Mom.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VitalInformationController : ControllerBase
    {
        public VitalInformationController()
        {

        }

        [HttpGet]
        public ActionResult<List<VitalInformation>> GetAll()
        {
            return VitalInformationService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<VitalInformation> Get(int id)
        {
            var vitalInformationRecord = VitalInformationService.Get(id); 

            if(vitalInformationRecord == null)
            {
                return NotFound();
            }
            return vitalInformationRecord;
        }

        [HttpPost]
        public IActionResult Create(VitalInformation vitalInformation)
        {
            VitalInformationService.Add(vitalInformation);
            return CreatedAtAction(nameof(Create), new { id = vitalInformation.Id }); 
        }

        [HttpPut]
        public IActionResult Update(int id, VitalInformation vitalInformation)
        {
            if( id != vitalInformation.Id)
            {
                return BadRequest();
            }

            var existingVitalInformation = VitalInformationService.Get(id);
            if (existingVitalInformation == null)
            {
                return NotFound(); 
            }

            VitalInformationService.Update(vitalInformation); 

            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var vitalInformationId = VitalInformationService.Get(id);
            if (vitalInformationId == null)
            {
                return NotFound(); 
            }

            VitalInformationService.Delete(id);

            return NoContent();

        }


    }
}
