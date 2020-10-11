﻿namespace App_secundaria.ViewModel
{
    using App_secundaria.Views;
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class MenuItemViewModel
    {
        #region Properties
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }
        #endregion

        #region Commands
        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(Navigate);
            }
        }

        #endregion

        #region Methods
        private void Navigate()
        { 
            if (this.PageName == "RegisterPage")
            {
                Application.Current.MainPage = new RegisterPage();
            }
        }
        #endregion
    }
    }
