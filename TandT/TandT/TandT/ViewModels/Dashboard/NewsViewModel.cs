using Models.Base;
using Models.View;
using Prism.Modularity;
using Prism.Navigation;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TandT.ViewModels
{
	public class NewsViewModel : BaseTabVM
	{
        public NewsViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod, true){}

		public async override void Init()
		{
            var list = new List<News>();
            list.Add(new News());
            Items = new ObservableCollection<News>(list);
            RaisePropertyChanged("Items");
		}
        #region VAR 
        ObservableCollection<News> items;
        public ObservableCollection<News> Items {
            get { return items; }
            set { SetProperty(ref items, value); }
        }
        #endregion

    }
}
