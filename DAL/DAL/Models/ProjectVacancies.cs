namespace DAL.Models
{
    public class ProjectVacancies
    {
        public int Id { get; set; }
        public Vacancy Vacancy { get; set; }
        public Project Project { get; set; }
    }
}
