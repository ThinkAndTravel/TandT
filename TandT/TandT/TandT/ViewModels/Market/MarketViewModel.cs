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
	public class MarketViewModel : BaseVM
	{
        public MarketViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod)
        {
        }

        public override void Init()
        {
            
        }
        #region VAR 
        ObservableCollection<MarketItem> items;
        public ObservableCollection<MarketItem> Items {
            get { return items; }
            set { SetProperty(ref items, value); }
        }
        #endregion
    }
}
