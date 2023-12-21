namespace UserService.Models
{
    public class WorkExperience
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateOnly DataStart { get; set; }
        public DateOnly DateEnd { get; set; }
    }
}
