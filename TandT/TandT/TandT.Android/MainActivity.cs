using Android.App;
using Android.Content.PM;
using Android.OS;
using FFImageLoading;
using FFImageLoading.Forms.Droid;
using Prism;
using Prism.Ioc;

namespace TandT.Droid
{
    [Activity(Label = "TandT", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            CachedImageRenderer.Init(true);
            Rg.Plugins.Popup.Popup.Init(this, bundle);

            var config = new FFImageLoading.Config.Configuration()
            {
                VerboseLogging = false,
                VerbosePerformanceLogging = false,
                VerboseMemoryCacheLogging = false,
                VerboseLoadingCancelledLogging = false
            };

            ImageService.Instance.Initialize(config);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
        }
        public override void OnBackPressed()
        {
            if (Rg.Plugins.Popup.Popup.SendBackPressed(base.OnBackPressed))
            {
               // Debug.WriteLine("Android back button: There are some pages in the PopupStack");
            }
            else
            {
                //Debug.WriteLine("Android back button: There are not any pages in the PopupStack");
            }
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry container)
        {
            // Register any platform specific implementations
        }
    }
}

