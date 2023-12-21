namespace UserService.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> RequiredTeammates { get; set; }
        public User CodeReviewer { get; set; }
    }
}
