﻿using Prism.AppModel;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Models.Base
{
    public abstract class BaseVM : BindableBase, INavigationAware, IDestructible, IPageLifecycleAware
    {
        public readonly INavigationService Nav;

        public readonly IModuleManager Mod;

        #region VAR 

        private string _title = "";
        public string Title {
            get { return _title; }
            set {
                SetProperty(ref _title, value);
                Debug.WriteLine($"########Title : {_title}");
            }
        }

        #endregion

        public BaseVM(INavigationService nav, IModuleManager mod)
        {
            Nav = nav;
            Mod = mod;
            Debug.WriteLine("######################");
            Debug.WriteLine("Нова сторінка " + this.GetType());
        }


        public bool IsInit = false;
        public abstract void Init();

        public virtual void OnNavigatedFrom(NavigationParameters parameters) { }

        public async virtual void OnNavigatedTo(NavigationParameters parameters)
        {
            if (!IsInit)
            {
                IsInit = true;
                InitCancel = new CancellationTokenSource();
                await Task.Factory.StartNew(() =>
                { Init(); }, InitCancel.Token);
            }
        }

        public virtual void OnNavigatingTo(NavigationParameters parameters) { }

        public async virtual void Destroy()
        {
            try
            {
                InitCancel?.Cancel();
                IsInit = false;
            }
            catch
            {
                Debug.Write("CancelError");
            }
        }

        CancellationTokenSource InitCancel;
        public async virtual void OnAppearing()
        {
            if (!IsInit)
            {
                IsInit = true;
                InitCancel = new CancellationTokenSource();
                await Task.Factory.StartNew(() =>
                { Init(); }, InitCancel.Token);
            }
        }

        public async virtual void OnDisappearing()
        {

        }
    }
}