namespace App_secundaria.ViewModel
{
    using System;
    using System.Collections.ObjectModel;
    public class MainViewModel
    {
        #region Properties
        public ObservableCollection<MenuItemViewModel> Menus 
        { 
            get; 
            set; 
        }
        #endregion

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
            this.LoadMenu();
        }
        #endregion

        #region Methods
        private void LoadMenu()
        {
            this.Menus = new ObservableCollection<MenuItemViewModel>();

            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_settings",
                PageName = "Settings",
                Title = "Settings"
            });

            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_assessment",
                PageName = "Statics",
                Title = "Statics"
            });

            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_exit_to_app",
                PageName = "RegisterPage",
                Title = "LogOut"
            });
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
