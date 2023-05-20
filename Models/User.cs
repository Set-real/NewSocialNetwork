using Microsoft.AspNetCore.Identity;

namespace MySocialNetwork.Models
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidleName { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
