using MediClinic.Business.Interfaces;
using MediClinic.Business.Services;
using MediClinic.DataAccess.Interfaces;
using MediClinic.DataAccess.Repositories;
using MediClinic.Enums;
using MediClinic.Interfaces;
using MediClinic.Models;

namespace MediClinic.Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDoctorRepository doctorRepo = new DoctorRepository();
            IPatientRepository patientRepo = new PatientRepository();

            IDoctorService doctorService = new DoctorService(doctorRepo);
            IPatientService patientService = new PatientService(patientRepo);

            IDoctor dermatologist = new Dermatologist(Guid.NewGuid(), "DeWalt Andrew");
            IDoctor pediatrician = new Pediatrician(Guid.NewGuid(), "Swayer Anna");
            IDoctor gynecologist = new Gynecologist(Guid.NewGuid(), "Ronald Marilenne");

            doctorService.CreateDoctor(dermatologist);
            doctorService.CreateDoctor(pediatrician);
            doctorService.CreateDoctor(gynecologist);

            foreach (IDoctor doc in doctorService.GetAllDoctors())
            {
                Console.WriteLine(((BaseModel)doc).FullName);
            }

            try
            {
                Patient patient1 = new Patient(Guid.NewGuid(), "John Donald", 14, Gender.Male, pediatrician);
                patientService.CreatePatient(patient1);
                pediatrician.Examine(patient1);
                patient1.AdministerVaccine();
                pediatrician.PrescribeTreatment(patient1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Patient patient2 = new Patient(Guid.NewGuid(), "Bill Sofia", 65, Gender.Female, pediatrician);
                patientService.CreatePatient(patient2);
                pediatrician.Examine(patient2);
                pediatrician.PrescribeTreatment(patient2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Patient patient3 = new Patient(Guid.NewGuid(), "Willson Matt", 23, Gender.Male, gynecologist);
                patientService.CreatePatient(patient3);
                gynecologist.Examine(patient3);
                gynecologist.PrescribeTreatment(patient3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (Patient p in patientService.GetAllPatients())
            {
                Console.WriteLine($"{p.FullName} - Doctor: {((BaseModel)p.Doctor).FullName}");
            }
        }
    }
}
