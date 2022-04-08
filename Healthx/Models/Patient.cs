namespace Healthx.Api.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String Dob { get; set; }
        public string Email { get; set; }
        public Doctor Doctor { get ; set; }
        public Medication Medications { get; set; }
        public VitalInformation VitalInformation { get; set; }

    }
}
