using MediClinic.Business.Interfaces;
using MediClinic.DataAccess.Interfaces;
using MediClinic.Interfaces;

namespace MediClinic.Business.Services
{
    public class DoctorService : IDoctorService
    {
        public IDoctorRepository doctorRepo;

        public DoctorService(IDoctorRepository doctorRepo)
        {
            this.doctorRepo = doctorRepo;
        }

        public void CreateDoctor(IDoctor doctor)
        {
            doctorRepo.Create(doctor);
        }

        public ICollection<IDoctor> GetAllDoctors()
        {
            return doctorRepo.GetAll();
        }

        public IDoctor GetDoctorById(Guid id)
        {
            return doctorRepo.GetById(id);
        }

        public void UpdateDoctor(IDoctor updatedDoctor)
        {
            doctorRepo.Update(updatedDoctor);
        }

        public void DeleteDoctor(Guid id)
        {
            doctorRepo.Delete(id);
        }
    }
}