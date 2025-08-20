namespace MediClinic.Exceptions
{
    public class InvalidDoctorException : Exception
    {
        public InvalidDoctorException() : base() { }
        public InvalidDoctorException(string message) : base(message) { }
        public InvalidDoctorException(string message, Exception innerException) : base(message, innerException) { }
    }
}
