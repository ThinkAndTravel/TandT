using Prism;
using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace TandT.ViewModels
{
    public abstract class TabViewModelBase : BindableBase, IActiveAware, IDestructible, IPageLifecycleAware, INavigationAware
    {
        #region VAR 

        public bool IsFirstPage { get; set; } = false;

        public event EventHandler IsActiveChanged;

        private bool _isActive;
        public bool IsActive {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value, RaiseIsActiveChanged); }
        }

        
        private string _title = "";
        public string Title {
            get { return _title; }
            set {
                SetProperty(ref _title, value);
                Debug.WriteLine($"########Title : {_title}");
            }
        }

        public bool IsInit = false;

        public Color MainColor { get; } = Color.FromHex("#34273B");
        public Color UtilityColor { get; } = Color.FromHex("#29BDCB");

        #endregion

        protected virtual void RaiseIsActiveChanged()
        {
            IsActiveChanged?.Invoke(this, EventArgs.Empty);
        }

        CancellationTokenSource InitCancel;
        protected async void HandleIsActiveTrue(object sender, EventArgs args)
        {
            if (IsActive == false || IsInit == true)          
                return;
            InitCancel = new CancellationTokenSource();
            await Task.Factory.StartNew(() =>
                { Init(); }, InitCancel.Token);
            IsInit = true;
        }
        protected void HandleIsActiveFalse(object sender, EventArgs args)
        {
            if (IsActive == true) return;
        }

        public abstract void Init();

        public virtual void Destroy()
        {
            IsActiveChanged -= HandleIsActiveTrue;
            IsActiveChanged -= HandleIsActiveFalse;
            InitCancel?.Cancel();
           
        }

        public virtual void OnAppearing()
        {
            IsActiveChanged += HandleIsActiveTrue;
            IsActiveChanged += HandleIsActiveFalse;
            if (IsFirstPage)
                HandleIsActiveTrue(null, null);
        }

        public virtual void OnDisappearing()
        {
            
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
    }
}
