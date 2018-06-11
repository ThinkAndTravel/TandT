using BLL;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Identity.ViewModels
{
	public class RegistryViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService Nav;

        public RegistryViewModel(INavigationService nav)
        {
            Nav = nav;
        }

        #region VAR

        private string _email;
        public string Email {
            get {
                return _email;
            }

            set {
                SetProperty(ref _email, value);
            }
        }

        private string _password;
        public string Password {
            get {
                return _password;
            }

            set {
                SetProperty(ref _password, value);
            }
        }

        private string _retypePassword;
        public string RetypePassword {
            get {
                return _retypePassword;
            }

            set {
                SetProperty(ref _retypePassword, value);
            }
        }

        private bool _agree = false;
        public bool Agree {
            get {
                return _agree;
            }

            set {
                SetProperty(ref _agree, value);
            }
        }

        #endregion

        private DelegateCommand _loginCommand;
        public virtual DelegateCommand LoginCommand {
            get {
                _loginCommand = _loginCommand ?? new DelegateCommand(AttemptLogin);
                return _loginCommand;
            }
        }

        private DelegateCommand _submitCommand;
        public virtual DelegateCommand SubmitCommand {
            get {
                _submitCommand = _submitCommand ?? new DelegateCommand(AttemptSubmit);
                return _submitCommand;
            }
        }

        private async void AttemptSubmit()
        {
            if (Agree)
                await Nav.NavigateAsync("Verify");
        }

        private async void AttemptLogin()
        {
           await Nav.GoBackAsync();
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
        public async void OnNavigatedFrom(NavigationParameters parameters)
        {
            try
            {
                if (Agree && Password == RetypePassword && Password.Length > 5 && Email.Length > 3)
                {
                    var data = new Dictionary<string, string>();
                    data.Add("password", Password);
                    data.Add("email", Email);
                    await UserSetting.Registration(data);
                    await Nav.GoBackAsync();
                }
            }
            catch
            {
            }
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }
    }
}
