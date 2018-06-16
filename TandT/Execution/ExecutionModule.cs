using Prism.Ioc;
using Prism.Modularity;
using Execution.Views;
using Execution.ViewModels;

namespace Execution
{
    public class ExecutionModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
           // containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}
