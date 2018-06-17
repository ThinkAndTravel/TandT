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
            containerRegistry.RegisterForNavigation<UserQuests, UserQuestsViewModel>("UserQ");
            containerRegistry.RegisterForNavigation<Quests,QuestsViewModel>("Q");
            containerRegistry.RegisterForNavigation<Market,MarketViewModel>("Market");
            containerRegistry.RegisterForNavigation<Friends, FriendsViewModel>("Friends");
            containerRegistry.RegisterForNavigation<Plans, PlansViewModel>("Plans");
            containerRegistry.RegisterForNavigation<QCategory,QCategoryViewModel>("QCategory");
            containerRegistry.RegisterForNavigation<NewPlan,NewPlanViewModel>("NewPlan");
            containerRegistry.RegisterForNavigation<FriendPlans, FriendsViewModel>("FriendPlans");
            containerRegistry.RegisterForNavigation<MyPlans,MyPlansViewModel>("MyPlans");
            containerRegistry.RegisterForNavigation<Setup,SetupViewModel>("Setup");
            containerRegistry.RegisterForNavigation<RecommendedQ, RecommendedQViewModel>("RecommendedQ");
            containerRegistry.RegisterForNavigation<QPersonal, QPersonalViewModel>("QPersonal");
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule(new ModuleInfo(typeof(Identity.IdentityModule), "Identity", InitializationMode.OnDemand));
            
            moduleCatalog.AddModule(new ModuleInfo(typeof(Execution.ExecutionModule), "Execution", InitializationMode.OnDemand));
        }
    }
}
