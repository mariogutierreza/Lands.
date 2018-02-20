namespace Lands.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        private LoginViewModel Login
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            Login = new LoginViewModel();
        }
        #endregion
    }
}
