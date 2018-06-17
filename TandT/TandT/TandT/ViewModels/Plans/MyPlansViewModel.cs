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
    public class MyPlansViewModel : BaseTabVM
    {
        public MyPlansViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod, true)
        {
        }

        public override void Init()
        {
        }
        #region VAR 
        ObservableCollection<PlanView> items;
        public ObservableCollection<PlanView> Items {
            get { return items; }
            set { SetProperty(ref items, value); }
        }
        #endregion
    }
}
