using Models.Base;
using Models.View;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.Generic;
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
            var list = new List<QuestItem>();

            list.Add(new QuestItem());
            Items = new ObservableCollection<QuestItem>(list);
        }

        #region VAR 
        ObservableCollection<QuestItem> items;
        public ObservableCollection<QuestItem> Items {
            get { return items; }
            set { SetProperty(ref items, value); }
        }
        #endregion
    }
}
