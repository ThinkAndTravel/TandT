using Prism.Ioc;
using Prism.Modularity;
using ContentView.Views;
using ContentView.ViewModels;

namespace ContentView
{
    public class ContentViewModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}
