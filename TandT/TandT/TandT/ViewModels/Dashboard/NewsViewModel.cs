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
            var list = new List<NewsItem>();
            list.Add(new NewsItem());
            Items = new ObservableCollection<NewsItem>(list);
            RaisePropertyChanged("Items");
		}
        #region VAR 
        ObservableCollection<NewsItem> items;
        public ObservableCollection<NewsItem> Items {
            get { return items; }
            set { SetProperty(ref items, value); }
        }
        #endregion

    }
}
