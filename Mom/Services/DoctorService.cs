using Mom.Models;

namespace Mom.Services
{
    public static class DoctorService
    {
        static List<Doctor> Doctors { get;  }
        static int nextId = 3;
        static DoctorService()
        {
            Doctors = new List<Doctor>
            {
                new Doctor
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Mutac"
                },
                new Doctor
                {
                    Id = 2,
                    FirstName = "Vanessa",
                    LastName = "Tisdale"
                }
            };
        }

        public static List<Doctor> GetAll() => Doctors;

        public static Doctor? Get(int id) => Doctors.FirstOrDefault(p => p.Id == id);

        public static void Add(Doctor doctor)
        {
            doctor.Id = nextId++;
            Doctors.Add(doctor);
        }

        public static void Delete(int id)
        {
            var pizza = Get(id);
            if (pizza is null)
                return;

            Doctors.Remove(pizza);
        }

        public static void Update(Doctor doctor)
        {
            var index = Doctors.FindIndex(p => p.Id == doctor.Id);
            if (index == -1)
                return;

            Doctors[index] = doctor;
        }
    }
}
