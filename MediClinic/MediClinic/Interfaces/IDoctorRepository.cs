using MediClinic.Interfaces;

namespace MediClinic.DataAccess.Interfaces
{
    public interface IDoctorRepository
    {
        void Create(IDoctor doctor);
        List<IDoctor> GetAll();
        IDoctor GetById(Guid id);
        void Update(IDoctor updatedDoctor);
        void Delete(Guid id);
    }
}
