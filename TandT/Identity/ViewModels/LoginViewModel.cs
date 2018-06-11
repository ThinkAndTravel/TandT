using Prism.Commands;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;

namespace Identity.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        private readonly INavigationService Nav;
        private readonly IModuleManager Mod;

        public LoginViewModel(INavigationService navigationService, IModuleManager module) 
        {
            Nav = navigationService;
            Mod = module;
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
            await Nav.NavigateAsync("Registry");
        }

        private async void AttemptForgotPas()
        {
            await Nav.NavigateAsync("Forgot");
        }

        private async void AttemptLogin()
        {
            if (CanExecuteLogin)
                if (!await BLL.AuthService.Login(email, password))
                {
                    BLL.UserSetting.NewSession(email,password);
                    await Nav.GoBackAsync();
                }
                else
                {
                    Mod.LoadModule("Popup");
                    var data = new Dictionary<string, string>();
                    data.Add("Msg", "Login failed. Please try again.");
                    data.Add("Title", "ERROR");
                    if (Popup.PopupService.AddNewParameters(data))
                        await PopupNavigation.PushAsync(new Popup.Views.Alert());
                }
        }

        private bool _canExecuteLogin()
        {
            return (!string.IsNullOrEmpty(Email) || !string.IsNullOrWhiteSpace(Email))
                   && (!string.IsNullOrEmpty(Password) || !string.IsNullOrWhiteSpace(Password));
        }

        public void Init()
        {
        }
    }
}
