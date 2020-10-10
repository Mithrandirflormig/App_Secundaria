namespace App_secundaria
{
    using App_secundaria.Views;
    using Xamarin.Forms;

    public partial class App : Application
    {
        #region Properties
        public static NavigationPage Navigator { get; internal set; }
        #endregion

        #region Constructors
        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage(new RegisterPage());
        }
        #endregion

        #region Constructors
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        } 
        #endregion
    }
}
