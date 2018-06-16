using TandT.ViewModels;
using Xamarin.Forms;

namespace TandT.Views.Menu
{
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async void OnItemTapped(object sender, ItemTappedEventArgs args)
        {
            this.IsPresented = false;
            ((MenuViewModel)this.BindingContext).NavigateCommand.Execute(((ViewModels.MenuItem)args.Item));
            this.MenuList.SelectedItem = null;
        }
    }
}