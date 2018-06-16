using Models.Base;
using Prism.Modularity;
using Prism.Navigation;
namespace TandT.ViewModels
{
	public class NewsViewModel : BaseTabVM
	{
        public NewsViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod, true){}

		public async override void Init()
		{
			
		}

		
	}
}
