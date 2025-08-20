using MediClinic.DataAccess.Interfaces;
using MediClinic.Models;

namespace MediClinic.DataAccess.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private List<Patient> patients = new List<Patient>();

        public void Create(Patient patient)
        {
            if (!patients.Contains(patient))
            {
                patients.Add(patient);
                Console.WriteLine($"Patient {patient.FullName} added successfully!");
            }
            else
            {
                Console.WriteLine($"Patient {patient.FullName} already exists!");
            }
        }

        public List<Patient> GetAll()
        {
            return patients;
        }

        public Patient GetById(Guid id)
        {
            return patients.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Patient updatedPatient)
        {
            Patient existing = patients.FirstOrDefault(p => p.Id == updatedPatient.Id);
            
            if (existing != null)
            {
                existing.FullName = updatedPatient.FullName;
                existing.Age = updatedPatient.Age;
                existing.Gender = updatedPatient.Gender;
                existing.Doctor = updatedPatient.Doctor;
               
                Console.WriteLine($"Patient updated successfully!");
            }
        }

        public void Delete(Guid id)
        {
            var patientToBeRemoved = patients.FirstOrDefault(p => p.Id == id);
            
            if (patientToBeRemoved != null)
            {
                patients.Remove(patientToBeRemoved);
                Console.WriteLine($"Patient removed successfully!");
            }
        }
    }
}