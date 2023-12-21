using UserService.Enums;

namespace UserService.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string RequiredPosition { get; set; }
        public EWorkExperience WorkExperience { get; set; }
        public EWorkSchedule WorkSchedule { get; set; }
    }
}
