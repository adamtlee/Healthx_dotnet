using Mom.Api.Models;

namespace Mom.Api.Services
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
                    Name = "John C Hornsby",
                    Specialization = "Family Care",
                    Clinic = "Primal Health Group",
                    Address = "123 Fake Street",
                    Phone = "(303) 333-3333",
                    Email = "John@pghmail.com",
                    Assistant = "N/A",
                    Notes = " N/A "

                },
                new Doctor
                {
                    Id = 2,
                    Name = "Seitha T Mutac",
                    Specialization = "Oncology",
                    Clinic = "Primal Health Group",
                    Address = "124 Fake Street",
                    Phone = "(303) 233-3333",
                    Email = "Seitha@phgmail.com",
                    Assistant = "Vanessa",
                    Notes = " N/A "
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
            var doctor = Get(id);
            if (doctor is null)
                return;

            Doctors.Remove(doctor);
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
