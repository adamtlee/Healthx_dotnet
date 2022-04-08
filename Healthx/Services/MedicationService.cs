using Healthx.Api.Models;

namespace Healthx.Api.Services
{
    public class MedicationService
    {
        
        static List<Medication> Medications { get; }
        static int nextId = 3;

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

        public static List<Medication> GetAll() => Medications;

        public static Medication? Get(int id) => Medications.FirstOrDefault(m => m.Id == id);

        public static void Add(Medication medication)
        {
            medication.Id = nextId++; 
            Medications.Add(medication);
        }

        public static void Delete(int id)
        {
            var medication = Get(id);
            if(medication is null)
            {
                return;
            }
            Medications.Remove(medication);
        }

        public static void Update(Medication medication)
        {
            var index = Medications.FindIndex(m => m.Id == medication.Id);
            if (index == -1)
                return;
            Medications[index] = medication; 
        }
    }
}
