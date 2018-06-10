using Prism.Modularity;
using Prism.Mvvm;
using Prism.Navigation;

namespace TandT.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private readonly IModuleManager _moduleManager;
        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService, IModuleManager module) 
        {
            _moduleManager = module;
            _navigationService = navigationService;
            Init();
        }

        public async void Init()
        {
            if (BLL.UserSetting.Data.ContainsKey("email"))
            {
            }
            else
            {
                _moduleManager.LoadModule("Identity");
                await _navigationService.NavigateAsync("Login");
            }
        }
    }
}
