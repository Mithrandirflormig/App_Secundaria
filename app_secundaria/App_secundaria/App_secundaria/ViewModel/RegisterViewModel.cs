namespace App_secundaria.ViewModel
{
    using GalaSoft.MvvmLight.Command;
    using System.ComponentModel;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class RegisterViewModel : BaseViewModel
    {

        #region Attributes
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Properties
        public string Email 
        { 
            get; 
            set; 
        }

        public string Password 
        {
            get
            {
                return this.password;
            }
            set
            {
                Setvalue(ref this.password, value);
            }
        }

        public bool IsRemember 
        { 
            get; 
            set; 
        }

        public bool IsRunning 
        {
            get
            {
                return this.isRunning;
            }
            set
            {
                Setvalue(ref this.isRunning, value);
            }
        }

        public bool IsEnabled 
        {
            get
            {
                return this.isEnabled;
            }
            set
            {
                Setvalue(ref this.isEnabled, value);
            }
        }
        #endregion

        #region Commands
        public ICommand GoCommand 
        { 
            get
            {
                return new RelayCommand(Go);
            }
        }


        private async void Go()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error", 
                    "You must enter an email", 
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an Password",
                    "Accept");
                return;
            }

            this.IsRunning = true;
            this.IsEnabled = false;

            if (this.Email != "mario@gmail.com" || this.Password != "1234")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or Password Incorrect",
                    "Accept");
                this.Password = string.Empty;
                return;
            }

            this.IsRunning = false;
            this.IsEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                    "Perfect",
                    "Let´s go!",
                    "Accept");
            return;
        }
        #endregion

        #region Constructors
        public RegisterViewModel()
        {
            this.IsRemember = true;
            this.IsEnabled = true;
        }

        #endregion
    }
}
