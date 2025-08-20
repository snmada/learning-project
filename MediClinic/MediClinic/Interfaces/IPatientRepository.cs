using MediClinic.Models;

namespace MediClinic.DataAccess.Interfaces
{
    public interface IPatientRepository
    {
        void Create(Patient patient);
        List<Patient> GetAll();
        Patient GetById(Guid id);
        void Update(Patient updatedPatient);
        void Delete(Guid id);
    }
}
