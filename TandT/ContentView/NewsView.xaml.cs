using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewsView : ViewCell
    {
		public NewsView ()
		{
			InitializeComponent ();
		}

        private void Share(object sender, System.EventArgs e)
        {
            
        }
        private void Like(object sender, System.EventArgs e)
        {

        }
        private void Comment(object sender, System.EventArgs e)
        {

        }
    }
}