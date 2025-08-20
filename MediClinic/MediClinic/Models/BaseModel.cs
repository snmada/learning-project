namespace MediClinic.Models
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
    }
}
