namespace App_secundaria.ViewModel
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    public class LoginViewModel
    {
        #region Properties

        #endregion

        #region Constructors
       
        #endregion

        #region Commands
        public ICommand SignInCommand 
        {
            get
            {
                return new RelayCommand(SignIn);
            }
                
        }

        private void SignIn()
        {

        }
        #endregion
    }
}
