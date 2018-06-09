using Prism.Ioc;
using Prism.Modularity;
using Identity.Views;
using Identity.ViewModels;

namespace Identity
{
    public class IdentityModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Login, LoginViewModel>("Login");
            containerRegistry.RegisterForNavigation<Registry, RegistryViewModel>("Registry");
            containerRegistry.RegisterForNavigation<ForgotPass, ForgotPassViewModel>("Forgot");
        }
    }
}
