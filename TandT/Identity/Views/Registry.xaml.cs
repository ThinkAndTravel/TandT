using Xamarin.Forms;

namespace Identity.Views
{
    public partial class Registry : ContentPage
    {
        public Registry()
        {
            InitializeComponent();
        }
        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            Device.OpenUri(new System.Uri("https://www.cryptonext.net/terms.php?page=terms"));
        }
    }
}
