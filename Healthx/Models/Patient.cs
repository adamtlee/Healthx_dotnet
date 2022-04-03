namespace Healthx.Api.Models
{
    public class Patient
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly Dob { get; set; }
        public string Email { get; set; }
        public Doctor doctor { get ; set; }
        public Medication medications { get; set; }
        public VitalInformation vitalInformation { get; set; }

    }
}
