namespace MediClinic.Exceptions
{
    public class InvalidVaccineAdministrationException : Exception
    {
        public InvalidVaccineAdministrationException() : base() { }
        public InvalidVaccineAdministrationException(string message) : base(message) { }
        public InvalidVaccineAdministrationException(string message, Exception innerException) : base(message, innerException) { }
    }
}
