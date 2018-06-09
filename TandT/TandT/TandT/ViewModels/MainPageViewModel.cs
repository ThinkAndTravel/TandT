using Prism.Modularity;
using Prism.Navigation;

namespace TandT.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IModuleManager _moduleManager;
        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService, IModuleManager module) 
            : base (navigationService)
        {
            _moduleManager = module;
            Title = "Main Page";
        }

    }
}
