namespace App_secundaria.Infrastructure
{
    using ViewModel;
    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel(); //Aqui ligamos la MainViewModel con la ´´agina Login
        }
        #endregion
    }
}
