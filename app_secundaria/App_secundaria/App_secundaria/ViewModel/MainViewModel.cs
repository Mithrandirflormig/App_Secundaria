namespace App_secundaria.ViewModel
{
    public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login { get; set; }

        public RegisterViewModel Register { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            this.Login = new LoginViewModel();

            this.Register = new RegisterViewModel();
        }
        #endregion
    }
}
