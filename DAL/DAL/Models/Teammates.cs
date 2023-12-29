namespace DAL.Models
{
    public class Teammates
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Project Project { get; set; }
    }
}
