using Prism.Ioc;
using Prism.Modularity;
using Popup.Views;
using Popup.ViewModels;

namespace Popup
{
    public class PopupModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Alert, AlertViewModel>();
        }
    }
}
