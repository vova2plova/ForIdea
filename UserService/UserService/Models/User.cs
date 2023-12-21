using Microsoft.AspNetCore.Identity;

namespace UserService.Models
{
    public class GoogleAPIData
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public EAccountType AccountType { get; set; }
    }

    public class Curriculum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
        public string Path { get; set; }
    }

    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<User> Teammates { get; set; }
        public List<string> RequiredTeammates { get; set; }
        public List<Vacancy> Vacancies { get; set; }
        public User CodeReviewer { get; set; }
    }
    
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public List<Vacancy> Vacancies { get; set; }
        public List<User> HRs { get; set; }
        public User Creator { get; set; }
    }

    public class Vacancy 
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string RequiredPosition { get; set; }
        public EWorkExperience WorkExperience { get; set; }
        public EWorkSchedule WorkSchedule { get; set; }
    }

    public enum EWorkSchedule
    {
        None = 0,
        FullDay = 1,
        Remote = 2,
        Flexible = 3,
        Shift = 4,
    }
    public enum ETypeOfEmployment
    {
        None = 0,
        Full = 1,
        Internship = 2,
        Partial = 3,
    }

    public enum EAccountType
    {
        User = 0,
        Hr = 1,
        CodeReviewer = 2,
        Admin = 3,
    }

    public enum EWorkExperience
    {
        None = 0,
        Small = 1,
        Medium = 2,
        Big = 3,
        More = 4,
    }
}
