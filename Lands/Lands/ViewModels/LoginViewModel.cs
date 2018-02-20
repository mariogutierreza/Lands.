namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Forms;

    class LoginViewModel
    {
        #region Properties
        public string Email
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }

        public bool IsRemembered
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
        }

        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get

            {
                return new RelayCommand(Login);
            }
            
        }

        private async void Login()
        {
           if (String.IsNullOrEmpty(this.Email))
                {
                    await Application.Current.MainPage.DisplayAlert(
                         "Error",
                         "You must enter an email",
                         "Accept");
                    return;
                }

            if (String.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                     "Error",
                     "You must enter a password",
                     "Accept");
                return;
            }

            }
        #endregion
    }
}
