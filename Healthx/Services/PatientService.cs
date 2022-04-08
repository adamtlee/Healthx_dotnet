using Healthx.Api.Models;

namespace Healthx.Api.Services
{
    public class PatientService
    {
        static List<Patient> Patients { get; }
        static int nextId = 3; 

        static PatientService()
        {
            Patients = new List<Patient>
            {
                new Patient
                {
                    Id = 1,
                    FirstName = "Harry",
                    LastName = "Potter",
                    Email = "HarryP@Hogwarts.edu",
                    Dob = "12-13-1991",
                    Doctor = DoctorService.Get(1),
                    Medications = MedicationService.Get(1),
                    VitalInformation = VitalInformationService.Get(1)

                },
                new Patient
                {
                    Id = 2,
                    FirstName = "Hermione",
                    LastName = "Granger",
                    Email = "HermioneG@Hogwarts.edu",
                    Dob = "07-12-1990",
                    Doctor = DoctorService.Get(2),
                    Medications = MedicationService.Get(2),
                    VitalInformation = VitalInformationService.Get(2)

                }
            };

        }

        public static List<Patient> GetAll() => Patients;

        public static Patient? Get(int id) => Patients.FirstOrDefault(p => p.Id == id);

        public static void Add(Patient patient)
        {
            patient.Id = nextId++; 
            Patients.Add(patient);
        }

        public static void Delete(int id)
        {
            var patient = Get(id);
            if (patient is null)
                return;
            Patients.Remove(patient);
        }

        public static void Update(Patient patient)
        {
            var index = Patients.FindIndex(p => p.Id == patient.Id);
            if (index == -1)
                return;

            Patients[index] = patient;
        }
    }
}
