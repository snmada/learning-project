using MediClinic.DataAccess.Interfaces;
using MediClinic.Interfaces;
using MediClinic.Models;

namespace MediClinic.DataAccess.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly List<IDoctor> doctors = new List<IDoctor>();

        public void Create(IDoctor doctor)
        {
            if (!doctors.Contains(doctor))
            {
                doctors.Add(doctor);
                Console.WriteLine($"Dr. {((BaseModel)doctor).FullName} added successfully!");
            }
            else
            {
                Console.WriteLine($"Dr. {((BaseModel)doctor).FullName} already exists!");
            }
        }

        public List<IDoctor> GetAll()
        {
            return doctors;
        }

        public IDoctor GetById(Guid id)
        {
            //var doctor = doctors.FirstOrDefault(d => ((BaseModel)d).Id == id);
            //if (doctor != null)
            //{
            //    return doctor;
            //}
            //throw new ArgumentException();

            return doctors.FirstOrDefault(d => ((BaseModel)d).Id == id) ?? throw new ArgumentException();
        }

        public void Update(IDoctor updatedDoctor)
        {
            IDoctor existing = doctors.FirstOrDefault(d => ((BaseModel)d).Id == ((BaseModel)updatedDoctor).Id) ?? throw new ArgumentException();
            
            if (existing != null)
            {
                ((BaseModel)existing).FullName = ((BaseModel)updatedDoctor).FullName;
                Console.WriteLine($"Doctor updated successfully!");
            }
        }

        public void Delete(Guid id)
        {
            IDoctor doctorToBeRemoved = doctors.FirstOrDefault(d => ((BaseModel)d).Id == id) ?? throw new ArgumentException();
            
            if (doctorToBeRemoved != null)
            {
                doctors.Remove(doctorToBeRemoved);
                Console.WriteLine($"Doctor removed successfully!");
            }
        }
    }
}