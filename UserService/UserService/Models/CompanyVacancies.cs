namespace UserService.Models
{
    public class CompanyVacancies
    {
        public int Id { get; set; }
        public Vacancy Vacancy { get; set; }
        public Company Company { get; set; }
    }
}
