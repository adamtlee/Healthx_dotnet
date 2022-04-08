using Healthx.Api.Models;
using Healthx.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Healthx.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        public PatientController()
        {

        }

        [HttpGet]
        public ActionResult<List<Patient>> GetAll()
        {
            return PatientService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Patient> Get(int id)
        {
            var patient = PatientService.Get(id);
            if (patient == null)
            {
                return NotFound(); 
            }
            return patient;
        }

        [HttpPost]
        public IActionResult Create(Patient patient)
        {
            PatientService.Add(patient);
            return CreatedAtAction(nameof(Create), new { id = patient.Id }, patient);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Patient patient)
        {
            if(id != patient.Id)
            {
                return BadRequest();
            }

            var existingPatient = PatientService.Get(id);
            PatientService.Update(existingPatient);
            if(existingPatient is null)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var patientId = MedicationService.Get(id); 
            if(patientId is null)
            {
                return NotFound(); 
            }
            PatientService.Delete(id);

            return NoContent();
        }
    }
}
