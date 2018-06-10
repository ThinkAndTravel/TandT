using Identity.ViewModels;
using Xamarin.Forms;

namespace Identity.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            ((LoginViewModel)this.BindingContext).ForgotCommand.Execute();
        }
    }
}
