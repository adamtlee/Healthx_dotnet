using Healthx.Api.Models;

namespace Healthx.Api.Services
{
    public class MedicationService
    {
        static int nextId = 3; 
        static List<Medication> Medications { get; }

        static MedicationService()
        {
            Medications = new List<Medication>
            { 
                new Medication
                {
                    Id = 1,
                    Label = "Tylenol",
                    Dosage = 154.4f,
                    DateTimeStamp = DateTime.Now,
                    Summary = "Test Medication"
                },
                new Medication
                {
                    Id = 2,
                    Label = "Meletonin",
                    Dosage = 14.2f,
                    DateTimeStamp = DateTime.Now,
                    Summary = "Test Medication 2"
                }
            };

        }
    }
}
