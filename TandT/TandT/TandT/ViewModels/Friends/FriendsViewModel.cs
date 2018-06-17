using Models.Base;
using Models.View;
using Prism.Modularity;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace TandT.ViewModels
{
	public class FriendsViewModel : BaseVM
	{

        public FriendsViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod)
        {
        }

        public override void Init()
        {
            
        }
        #region VAR 
        ObservableCollection<UserItem> items;
        public ObservableCollection<UserItem> Items {
            get { return items; }
            set { SetProperty(ref items, value); }
        }
        #endregion
    }
}
