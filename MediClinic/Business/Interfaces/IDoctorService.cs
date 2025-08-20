using MediClinic.Interfaces;

namespace MediClinic.Business.Interfaces
{
    public interface IDoctorService
    {
        void CreateDoctor(IDoctor doctor);
        ICollection<IDoctor> GetAllDoctors();
        IDoctor GetDoctorById(Guid id);
        void UpdateDoctor(IDoctor updatedDoctor);
        void DeleteDoctor(Guid id);
    }
}
