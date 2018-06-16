using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Popup.ViewModels
{
	public class AlertViewModel : BindableBase
    {
        public AlertViewModel()
        {
            try
            {
                Msg = PopupService.Data?["Msg"] ?? "";
                Title = PopupService.Data?["Title"] ?? "";
                RaisePropertyChanged("Msg");
                RaisePropertyChanged("Title");
            }
            catch { }
            YesCommand = new DelegateCommand(YesSubmit);
            CancelCommand = new DelegateCommand(Cancel);
        }

        #region VAR
        public string CancelText { get; set; } = "Cancel";

        public string Title { get; set; } = "";

        public string Msg { get; set; } = "";

        #endregion

        public DelegateCommand YesCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }

        private async void YesSubmit()
        {
            var data = new Dictionary<string, string>();
            data.Add("flag", "true");
            PopupService.ReturnParameters(data);
            await PopupNavigation.PopAsync();
        }

        public async void Cancel()
        {
            var data = new Dictionary<string, string>();
            data.Add("flag", "false");
            PopupService.ReturnParameters(data);
            await PopupNavigation.PopAsync();
        }

       
        public void OnAppearing()
        {
            try
            {
                Msg = PopupService.Data?["Msg"] ?? "";
                Title = PopupService.Data?["Title"] ?? "";
                RaisePropertyChanged("Msg");
                RaisePropertyChanged("Title");
            }
            catch { }
        }
    }
}
