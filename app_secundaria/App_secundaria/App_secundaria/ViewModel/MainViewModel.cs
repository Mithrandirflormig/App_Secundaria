namespace App_secundaria.ViewModel
{
    public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login { get; set; }

        public RegisterViewModel Register { get; set; }

        public MasterViewModel Master { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
            this.Register = new RegisterViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        
        
        #endregion
    }
}
