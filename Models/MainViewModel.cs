namespace MySocialNetwork.Models
{
    public class MainViewModel
    {
        public RegisterViewModel RegisterView { get; set; }


        public MainViewModel()
        {
            RegisterView = new RegisterViewModel();
        }
    }
}
