using Models.Base;
using Prism.Modularity;
using Prism.Navigation;

namespace TandT.ViewModels
{
	public class NewPlanViewModel : BaseTabVM
	{

        public NewPlanViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod, false)
        {
        }

        public override void Init()
        {
            
        }
    }
}
