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
    }
}
