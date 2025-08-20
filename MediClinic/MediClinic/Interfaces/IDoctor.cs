using MediClinic.Models;

namespace MediClinic.Interfaces
{
    public interface IDoctor
    {
        void Examine(Patient patient);
        void PrescribeTreatment(Patient patient);
    }
}
