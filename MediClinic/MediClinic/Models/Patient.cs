using MediClinic.Enums;
using MediClinic.Exceptions;
using MediClinic.Interfaces;

namespace MediClinic.Models
{
    public class Patient : BaseModel
    {
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public IDoctor Doctor { get; set; }

        public Patient(Guid Id, string FullName, int Age, Gender Gender, IDoctor Doctor)
        {
            this.Id = Id;
            this.FullName = FullName;
            this.Age = Age;
            this.Gender = Gender;
            this.Doctor = Doctor;

            ValidateDoctorAgeCompatibility();
            ValidateGenderDoctorCompatibility();
        }

        public void ValidateDoctorAgeCompatibility()
        {
            if (Doctor is Pediatrician && Age > 18)
            {
                throw new InvalidAgeException($"IMPORTANT: Patient {FullName} is over 18 years old and cannot be examined by a pediatrician");
            }
        }

        public void ValidateGenderDoctorCompatibility()
        {
            if (Doctor is Gynecologist && Gender == Gender.Male)
            {
                throw new InvalidDoctorException($"IMPORTANT: Patient {FullName} is male and cannot be examined by a gynecologist");
            }
        }

        public void AdministerVaccine()
        {
            if (Age < 5 || Age > 7)
            {
                throw new InvalidVaccineAdministrationException($"IMPORTANT: The vaccine can only be administered to children between 5 and 7 years old. Patient {FullName} is {Age} years old");
            }
            else
            {
                Console.WriteLine($"Vaccine administered to patient {FullName}");
            }
        }
    }
}
