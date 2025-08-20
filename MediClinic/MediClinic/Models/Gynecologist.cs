using MediClinic.Interfaces;

namespace MediClinic.Models
{
    public class Gynecologist : BaseModel, IDoctor
    {
        public Gynecologist(Guid Id, string FullName)
        {
            this.Id = Id;
            this.FullName = FullName;
        }

        public void Examine(Patient patient)
        {
            Console.WriteLine($"{patient.FullName} is being examined by the gynecologist Dr. {FullName}");
        }

        public void PrescribeTreatment(Patient patient)
        {
            Console.WriteLine($"{patient.FullName} is receiving a treatment plan from the gynecologist Dr. {FullName}");
        }

        public void PerformUltrasound()
        {
            Console.WriteLine($"Dr. {FullName} is performing an ultrasound....");
        }

    }
}