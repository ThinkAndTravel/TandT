using Models.Base;
using Prism.AppModel;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Navigation;
using System.Threading;

namespace TandT.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware,IPageLifecycleAware
    {
        public readonly INavigationService Nav;

        public readonly IModuleManager Mod;

        public MainPageViewModel(INavigationService nav, IModuleManager mod) 
        {
            Nav = nav;
            Mod = mod;
        }

        bool isBack= false;

        public async void Init()
        {
            
            if (BLL.AuthService.Logged)
            {
                await Nav.NavigateAsync("Menu/Nav/Dashboard?MyBalance&Markets");
            }
            else
            {
                Mod.LoadModule("Identity");
                await Nav.NavigateAsync("Login");                
            }
           
        }

        public void OnAppearing()
        {
            Init();
        }

        public void OnDisappearing()
        {
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {    
        }
    }
}
