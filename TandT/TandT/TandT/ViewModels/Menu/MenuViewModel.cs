using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TandT.ViewModels
{
	public class MenuViewModel : ViewModelBase
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

        public MenuViewModel(INavigationService navigationService) : base(navigationService)
        {
            
            NavigateCommand = new DelegateCommand<MenuItem>(OnNavigateCommandExecuted);
            MyProfileTappedCommand = new DelegateCommand(MyProfileTappedCommandExecuted);

            var _items = new ObservableCollection<MenuItem>();

            _items.Add(new MenuItem("Dashboard", "Dashboard?MyBalance&Markets", "house.png"));
            _items.Add(new MenuItem("Quests", "Quests?Cash&Digital&Requests", "map.png"));
            _items.Add(new MenuItem("Friends", "Dashboard?MyBalance&Markets", "map.png"));
            _items.Add(new MenuItem("Market", "Withdraw?WCash&WDigital&WEmail&WRequests", "store.png"));
            _items.Add(new MenuItem("Logout", /*"app:///Login?appModuleRefresh=OnInitialized"*/"", "logout.png"));

            Items = new ObservableCollection<MenuItem>(_items);

        }

        #region COMMAND

        public DelegateCommand<MenuItem> NavigateCommand { get; }

        public DelegateCommand MyProfileTappedCommand { get; }

        #endregion

        private async void OnNavigateCommandExecuted(MenuItem item) =>
           await Nav.NavigateAsync(item.Path);

        private void MyProfileTappedCommandExecuted()
        {
            //TODO 
        }

        public async void SetupTappedCommandExecuted()
        {
            await Nav.NavigateAsync("app:///SetupMenu/Nav/Contact?appModuleRefresh=OnInitialized");
        }

        public override async void Init()
        {
            //var info = await ViewModelBase.Auth?.GetMenuInfo();
            //AvatarUrl = @"https://cne.cryptonext.net/" + info.Item3;
            //Name = info.Item1;
            //Level = "Lvl: " + info.Item2;
            //RaisePropertyChanged("AvatarUrl");
            //RaisePropertyChanged("Level");
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

