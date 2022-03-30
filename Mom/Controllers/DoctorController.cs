using Microsoft.AspNetCore.Mvc;
using Mom.Models;
using Mom.Services;

namespace Mom.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorController : ControllerBase
    {
        public DoctorController()
        {

        }

        /// <summary>
        ///  Returns a List of All doctors
        /// </summary>
        /// <returns>List of Doctors</returns>
        [HttpGet]
        public ActionResult<List<Doctor>> GetAll()
        {
            return DoctorService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Doctor> Get(int id)
        {
            var doctor = DoctorService.Get(id);
            if (doctor == null)
            {
                return NotFound();
            }
            return doctor;
        }

        [HttpPost]
        public IActionResult Create(Doctor doctor)
        {
            DoctorService.Add(doctor);
            return CreatedAtAction(nameof(Create), new { id = doctor.Id }, doctor);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Doctor doctor)
        {
            if(id != doctor.Id)
            {
                return BadRequest();
            }

            var existingDoctor = DoctorService.Get(id);
            if (existingDoctor is null)
            {
                return NotFound();
            }

            DoctorService.Update(existingDoctor);

            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var doctorId = DoctorService.Get(id);

            if(doctorId == null)
            {
                return NotFound();
            }
            DoctorService.Delete(id);

            return NoContent();
        }
    }
}
