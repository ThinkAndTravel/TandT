using Prism;
using Prism.Ioc;
using TandT.ViewModels;
using TandT.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.DryIoc;
using Prism.Modularity;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TandT
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule(new ModuleInfo(typeof(Identity.IdentityModule), "Identity", InitializationMode.OnDemand));
            moduleCatalog.AddModule(new ModuleInfo(typeof(Popup.PopupModule), "Popup", InitializationMode.OnDemand));
        }
    }
}
