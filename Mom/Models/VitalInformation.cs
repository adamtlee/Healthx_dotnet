namespace Mom.Api.Models
{
    public class VitalInformation
    {
        public int Id { get; set; }
        public float Temperature { get; set; }
        public float Oxygen { get; set; }
        public int Pulse { get; set; }
        public float Weight { get; set; }
        public string Notes { get; set; }
        public string Assistant { get; set; }

        // public DateOnly Date { get; set; }
        // public TimeOnly Time { get; set; }
    }
}
