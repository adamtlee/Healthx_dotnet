using Healthx.Api.Models;

namespace Healthx.Api.Services
{
    public class VitalInformationService
    {

        static int nextId = 3;
        static List<VitalInformation> Vitals { get;  }

        static VitalInformationService()
        {
            Vitals = new List<VitalInformation>()
            {
                new VitalInformation()
                {
                    Id = 1,
                    Temperature = 98.7f,
                    Oxygen = 98,
                    Pulse = 75, 
                    Weight = 124.5f,
                    Notes = "N/A",
                    Assistant = "Kelly"
                },
                new VitalInformation()
                {
                    Id = 2,
                    Temperature = 94.7f,
                    Oxygen = 95,
                    Pulse = 79,
                    Weight = 154.5f,
                    Notes = "Test Two",
                    Assistant = "Zach"
                }
            };
        }
        public static List<VitalInformation> GetAll() => Vitals;


        public static VitalInformation? Get(int id) => Vitals.FirstOrDefault(v => v.Id == id);

        public static void Add(VitalInformation vitalInformation)
        {
            vitalInformation.Id = nextId++;
            Vitals.Add(vitalInformation);
        }

        public static void Delete(int id)
        {
            var vitalInformation = Get(id);
            if (vitalInformation is null)
                return;

            Vitals.Remove(vitalInformation);
        }

        public static void Update(VitalInformation vitalInformation)
        {
            var index = Vitals.FindIndex(p => p.Id == vitalInformation.Id);
            if (index == -1)
                return;

            Vitals[index] = vitalInformation;
        }
    }
}

