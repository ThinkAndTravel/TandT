﻿using Xamarin.Forms;

namespace TandT.Views.Friends
{
    public partial class Friends : ContentPage
    {
        public Friends()
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
