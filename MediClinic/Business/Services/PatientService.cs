using MediClinic.Business.Interfaces;
using MediClinic.DataAccess.Interfaces;
using MediClinic.Models;

namespace MediClinic.Business.Services
{
    public class PatientService : IPatientService
    {
        public IPatientRepository patientRepo;

        public PatientService(IPatientRepository patientRepo)
        {
            this.patientRepo = patientRepo;
        }

        public void CreatePatient(Patient patient)
        {
            patientRepo.Create(patient);
        }

        public List<Patient> GetAllPatients()
        {
            return patientRepo.GetAll();
        }

        public Patient GetPatientById(Guid id)
        {
            return patientRepo.GetById(id);
        }

        public void UpdatePatient(Patient updatedPatient)
        {
            patientRepo.Update(updatedPatient);
        }

        public void DeletePatient(Guid id)
        {
            patientRepo.Delete(id);
        }
    }
}
