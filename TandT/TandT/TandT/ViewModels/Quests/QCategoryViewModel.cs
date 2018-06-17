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
	public class QCategoryViewModel : BaseTabVM
	{
        public QCategoryViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod, false)
        {
        }

        public override void Init()
        {
            
        }
        #region VAR 
        ObservableCollection<CategoryItem> items;
        public ObservableCollection<CategoryItem> Items {
            get { return items; }
            set { SetProperty(ref items, value); }
        }
        #endregion
    }
}
