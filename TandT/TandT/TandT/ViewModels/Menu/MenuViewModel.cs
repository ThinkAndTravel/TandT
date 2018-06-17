using BLL;
using BLL.Setting;
using Models.Base;
using Prism.Commands;
using Prism.Modularity;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace TandT.ViewModels
{
	public class MenuViewModel : BaseVM
    {
        #region VAR 

        private ObservableCollection<MenuItem> items = new ObservableCollection<MenuItem>();
        public ObservableCollection<MenuItem> Items {
            get { return items; }
            set { SetProperty(ref items, value); }
        }

        public string AvatarUrl { get; set; } = "";
        public string Name { get; set; } = "";

        #endregion
        
        public MenuViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod)
        {
            
            NavigateCommand = new DelegateCommand<MenuItem>(OnNavigateCommandExecuted);
            
            var _items = new ObservableCollection<MenuItem>();

            _items.Add(new MenuItem("Dashboard", "Nav/Dashboard?MyBalance&Markets", "house.png"));
            _items.Add(new MenuItem("Quests", "Nav/Q?&RecommendedQ&QCategory&QPersonal", "map.png"));
            _items.Add(new MenuItem("Friends", "Nav/Friends", "users.png"));
            _items.Add(new MenuItem("Plans", "Nav/Plans?MyPlans&FriendPlans&NewPlan", "planning.png"));
            _items.Add(new MenuItem("Market", "Nav/Market", "store.png"));
            _items.Add(new MenuItem("Setup", "Nav/Setup", "gear.png"));
            _items.Add(new MenuItem("Logout", "app:///Main?appModuleRefresh=OnInitialized", "logout.png"));

            Items = new ObservableCollection<MenuItem>(_items);

        }

        #region COMMAND

        public DelegateCommand<MenuItem> NavigateCommand { get; }

        #endregion

        private async void OnNavigateCommandExecuted(MenuItem item)
        {   if (item.Logo == "logout.png")
                AuthService.CloseSession();
            await Nav.NavigateAsync(item.Path);
        }
       
            
        public override async void Init()
        {
            //var info = await ViewModelBase.Auth?.GetMenuInfo();
            //AvatarUrl = "https://scontent-frt3-2.xx.fbcdn.net/v/t1.0-9/24993442_721401698057538_830102265302037757_n.jpg?_nc_cat=0&oh=f7cc6001ea92acea19bfe698f5ed110b&oe=5BB26F96";
            Name = "Ivanenko";
            //RaisePropertyChanged("AvatarUrl");
            //RaisePropertyChanged("Name");
        }
    }

    public class MenuItem
    {
        public MenuItem(string title, string path, string logo)
        {
            Title = title;
            Path = path;
            Logo = logo;
        }

        public string Title { get; }
        public string Path { get; }
        public string Logo { get; }
    }

}

