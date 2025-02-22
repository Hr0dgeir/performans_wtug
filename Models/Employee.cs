namespace Performans_WTUG.Models
{
    public class Employee{
        public int ID { get; set; }
        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;
        public String FullName => $"{FirstName} {LastName.ToUpper()}";
        public int Age { get; set; }
    }
}