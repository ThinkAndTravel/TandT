using Models.Base;
using Models.View;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace TandT.ViewModels
{
    public class RecommendedQViewModel : BaseTabVM
    {
        public RecommendedQViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod, true)
        {
        }

        public override void Init()
        {
            
        }

        #region VAR 
        ObservableCollection<QuestView> items;
        public ObservableCollection<QuestView> Items {
            get { return items; }
            set { SetProperty(ref items, value); }
        }
        #endregion
    }
}
