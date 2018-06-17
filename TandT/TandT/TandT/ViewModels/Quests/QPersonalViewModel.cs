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
    public class QPersonalViewModel : BaseTabVM
    {
        public QPersonalViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod, false)
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
