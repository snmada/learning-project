using MediClinic.Models;

namespace MediClinic.Business.Interfaces
{
    public interface IPatientService
    {
        void CreatePatient(Patient patient);
        List<Patient> GetAllPatients();
        Patient GetPatientById(Guid id);
        void UpdatePatient(Patient updatedPatient);
        void DeletePatient(Guid id);
    }
}
