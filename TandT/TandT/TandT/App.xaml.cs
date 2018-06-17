using Prism;
using Prism.Ioc;
using TandT.ViewModels;
using TandT.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.DryIoc;
using Prism.Modularity;
using TandT.Views.Dashboard;
using TandT.Views.Market;
using TandT.Views.Plans;
using TandT.Views.Friends;
using TandT.Views.Quests;
using TandT.Views.Setup;

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
            containerRegistry.RegisterForNavigation<NavigationPage>("Nav");
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<TandT.Views.Menu.Menu, MenuViewModel>("Menu");
            containerRegistry.RegisterForNavigation<Dashboard, DashboardViewModel>("Dashboard");
            containerRegistry.RegisterForNavigation<News, NewsViewModel>("News");
            containerRegistry.RegisterForNavigation<Profile, ProfileViewModel>("Profile");
            containerRegistry.RegisterForNavigation<UserQuests>();
            containerRegistry.RegisterForNavigation<Quests>();
            containerRegistry.RegisterForNavigation<Market>();
            containerRegistry.RegisterForNavigation<Friends>();
            containerRegistry.RegisterForNavigation<Plans>();
            containerRegistry.RegisterForNavigation<QCategory>();
            containerRegistry.RegisterForNavigation<NewPlan>();
            containerRegistry.RegisterForNavigation<FriendPlans>();
            containerRegistry.RegisterForNavigation<MyPlans>();
            containerRegistry.RegisterForNavigation<Setup>();
            containerRegistry.RegisterForNavigation<RecommendedQ>();
            containerRegistry.RegisterForNavigation<PersonalQ>();
            containerRegistry.RegisterForNavigation<QPersonal>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule(new ModuleInfo(typeof(Identity.IdentityModule), "Identity", InitializationMode.OnDemand));
            
            moduleCatalog.AddModule(new ModuleInfo(typeof(Execution.ExecutionModule), "Execution", InitializationMode.OnDemand));
        }
    }
}
