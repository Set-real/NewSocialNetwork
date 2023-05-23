using Microsoft.AspNetCore.Identity;

namespace MySocialNetwork.Models.Users
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.UtcNow;
        public string Image { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

        public string About { get; set; } = string.Empty;

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public User()
        {
            Image = "https://via.placeholder.com/500";
            Status = "Ура! Я в соцсети!";
            About = "Информация обо мне.";
        }
    }
}
