﻿using Xamarin.Forms;

namespace TandT.Views.Quests
{
    public partial class QCategory : ContentPage
    {
        public QCategory()
        {
            InitializeComponent();
        }
        private async void OnItemTapped(object sender, ItemTappedEventArgs args)
        {
            //this.IsPresented = false;
            //((MenuViewModel)this.BindingContext).NavigateCommand.Execute(((ViewModels.MenuItem)args.Item));
            //this.MenuList.SelectedItem = null;
        }
    }
}
