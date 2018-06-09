using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Identity.ViewModels
{
    public class LoginViewModel : BindableBase
    {
      

        public LoginViewModel(INavigationService navigationService) 
        {  
            Init();
        }

        #region VAR

        private string email = "";
        public string Email {
            get {
                return email;
            }

            set {
                SetProperty(ref email, value);
            }
        }

        private string password = "";
        public string Password {
            get {
                return password;
            }
            set {              
                SetProperty(ref password, value);              
            }
        }

        #endregion VAR

        #region Commands

        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand {
            get {
                _loginCommand = _loginCommand ?? new DelegateCommand(AttemptLogin);
                return _loginCommand;
            }
        }

        public bool CanExecuteLogin {
            get { return _canExecuteLogin(); }
        }

        private DelegateCommand _forgotPasCommand;

        public DelegateCommand ForgotCommand {
            get {
                _forgotPasCommand = _forgotPasCommand ?? new DelegateCommand(AttemptForgotPas);
                return _forgotPasCommand;
            }
        }

        private DelegateCommand _createAccountCommand;

        public DelegateCommand CreateAccountCommand {
            get {
                _createAccountCommand = _createAccountCommand ?? new DelegateCommand(AttemptCreateAccount);
                return _createAccountCommand;
            }
        }

        #endregion Commands

        private async void AttemptCreateAccount()
        {
            await NavigationService.NavigateAsync("SignUp");//<SignUpViewModel>();
        }

        private async void AttemptForgotPas()
        {
            //TODO
        }

        private async void AttemptLogin()
        {
            if (CanExecuteLogin)
                if (await AuthService.Login(model))
                {
                    await NavigationService.NavigateAsync("Menu/Nav/Dashboard?MyBalance&Markets");
                }
                else
                {
                    //TODO _dialogService.Alert("We were unable to log you in!", "Login Failed", "OK");
                }
        }

        private bool _canExecuteLogin()
        {
            return (!string.IsNullOrEmpty(Email) || !string.IsNullOrWhiteSpace(Email))
                   && (!string.IsNullOrEmpty(Password) || !string.IsNullOrWhiteSpace(Password));
        }

        public override void Init()
        {
        }
    }
}
