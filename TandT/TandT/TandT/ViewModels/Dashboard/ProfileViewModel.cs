using Models.Base;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Navigation;

namespace TandT.ViewModels
{
    public class ProfileViewModel : BaseTabVM
    {
        public ProfileViewModel(INavigationService nav, IModuleManager mod, bool isFirst) : base(nav, mod, isFirst){}

        public async override void Init()
        {
           
        }
    }
}
