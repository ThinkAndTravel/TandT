using Xamarin.Forms;

namespace TandT.Views.Plans
{
    public partial class FriendPlans : ContentPage
    {
        public FriendPlans()
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
