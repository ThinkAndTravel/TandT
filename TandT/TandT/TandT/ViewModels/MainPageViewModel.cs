using Models.Base;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Navigation;

namespace TandT.ViewModels
{
    public class MainPageViewModel : BaseVM
    {
        public MainPageViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod){}

        public override async void Init()
        {
            if (BLL.AuthService.Logged)
            {
                await Nav.NavigateAsync("Menu/Nav");
            }
            else
            {
                Mod.LoadModule("Identity");
                await Nav.NavigateAsync("Login");
            }
        }

    }
}
