using Models.Base;
using Models.View;
using Prism.Commands;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TandT.ViewModels
{
	public class FriendPlansViewModel : BaseTabVM
	{
        public FriendPlansViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod, false)
        {
        }

        public override void Init()
        {
            
        }
        #region VAR 
        ObservableCollection<PlanItem> items;
        public ObservableCollection<PlanItem> Items {
            get { return items; }
            set { SetProperty(ref items, value); }
        }
        #endregion
    }
}
