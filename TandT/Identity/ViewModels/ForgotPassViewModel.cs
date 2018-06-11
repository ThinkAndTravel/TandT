using System;
using Prism.Commands;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Navigation;

namespace Identity.ViewModels
{
	public class ForgotPassViewModel : BindableBase
	{
        private readonly INavigationService Nav;
        private readonly IModuleManager Mod;

        public ForgotPassViewModel(INavigationService navigationService, IModuleManager module)
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

        #endregion VAR

        #region Commands

        private DelegateCommand _submitCommand;
        public DelegateCommand SubmitCommand {
            get {
                _submitCommand = _submitCommand ?? new DelegateCommand(AttemptSubmit);
                return _submitCommand;
            }
        }
        private async void AttemptSubmit()
        {
            await Nav.GoBackAsync();
        }

        private DelegateCommand _backCommand;
        public DelegateCommand BackCommand {
            get {
                _backCommand = _backCommand ?? new DelegateCommand(AttemptBack);
                return _backCommand;
            }
        }

        private async void AttemptBack()
        {
            await Nav.GoBackAsync();
        }

        #endregion Commands
    }
}
