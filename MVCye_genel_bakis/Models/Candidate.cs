namespace MVCye_genel_bakis.Models
{
    public class Candidate
    {
        public string Email { get; set; } = string.empty;
        public string FirstName { get; set; } = string.empty;
        public string LastName { get; set; } = string.empty;
        public string FullName => $"{FirstName} {LastName.ToUpper()}";
        public int Age { get; set; };
        public string Email { get; set; } = string.empty;
        public string SelectedCourse { get; set; } = string.empty;
        public DateTime ApplyAt { get; set; };
        public Candidate()
        {
            ApplyAt = Datetime.Now;
        }
    }
}