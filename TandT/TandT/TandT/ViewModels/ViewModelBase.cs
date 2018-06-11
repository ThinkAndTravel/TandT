using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;
using System.Threading;
using System.Threading.Tasks;

namespace TandT.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible, IPageLifecycleAware
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }

        public bool IsInit = false;
        public virtual void Init()
        {

        }

        CancellationTokenSource InitCancel;
        public async virtual void OnAppearing()
        {
            if (!IsInit)
            {
                InitCancel = new CancellationTokenSource();
                await Task.Factory.StartNew(() =>
                { Init(); }, InitCancel.Token);
                IsInit = true;
            }
        }

        public virtual void Destroy()
        {
            try
            {
                if (IsInit)
                    InitCancel?.Cancel();
            }
            catch
            {

            }
        }

        public void OnDisappearing()
        {
           
        }
    }
}
