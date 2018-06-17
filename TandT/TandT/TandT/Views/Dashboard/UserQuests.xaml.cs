using Xamarin.Forms;

namespace TandT.Views.Dashboard
{
    public partial class UserQuests : ContentPage
    {
        public UserQuests()
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
