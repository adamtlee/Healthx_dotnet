namespace Healthx.Api.Models
{
    public class Medication
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public float Dosage { get; set; }
        public string Summary { get; set; }
        public DateTime DateTimeStamp { get; set; }

    }
}
