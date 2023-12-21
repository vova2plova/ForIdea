using UserService.Enums;

namespace UserService.Models
{
    public class Curriculum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
        public string Path { get; set; }

        public WorkExperience WorkExperience { get; set; }
        public EWorkSchedule PreferWorkSchedule { get; set; }
    }
}
