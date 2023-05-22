using MySocialNetwork.Models.Users;

namespace MySocialNetwork.ViewModels.Account
{
    public class UserViewModel
    {
        public User user { get; set; }

        public UserViewModel(User user)
        {
            this.user = user;
        }
    }
}
