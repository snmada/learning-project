using MediClinic.Interfaces;

namespace MediClinic.Models
{
    public class Dermatologist : BaseModel, IDoctor
    {
        public Dermatologist(Guid Id, string FullName) 
        {
            this.Id = Id;
            this.FullName = FullName;
        }

        public void Examine(Patient patient)
        {
            Console.WriteLine($"{patient.FullName} is being examined by the dermatologist Dr. {FullName}");
        }

        public void PrescribeTreatment(Patient patient)
        {
            Console.WriteLine($"{patient.FullName} is receiving a treatment plan from the dermatologist Dr. {FullName}");
        }

        public void PerformFacialChemicalPeeling()
        {
            Console.WriteLine($"Dr. {FullName} is performing a facial chemical peeling....");
        }
    }
}
