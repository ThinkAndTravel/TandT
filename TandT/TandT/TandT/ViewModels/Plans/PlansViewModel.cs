using Models.Base;
using Prism.Modularity;
using Prism.Navigation;

namespace TandT.ViewModels
{
    public class PlansViewModel : BaseVM
    {
        public PlansViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod)
        {
            Title = "Plans";
        }

        public override void Init()
        {
        }
    }
}
