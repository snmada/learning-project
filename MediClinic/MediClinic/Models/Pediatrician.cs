using MediClinic.Interfaces;

namespace MediClinic.Models
{
    public class Pediatrician : BaseModel, IDoctor
    {
        public Pediatrician(Guid Id, string FullName)
        {
            this.Id = Id;
            this.FullName = FullName;
        }

        public void Examine(Patient patient)
        {
            Console.WriteLine($"{patient.FullName} is being examined by the pediatrician Dr. {FullName}");
        }

        public void PrescribeTreatment(Patient patient)
        {
            Console.WriteLine($"{patient.FullName} is receiving a treatment plan from the pediatrician Dr. {FullName}");
        }

        public void AdministerVaccine()
        {
            Console.WriteLine($"Dr. {FullName} is administering a vaccine....");
        }
    }
}