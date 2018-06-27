using Newtonsoft.Json;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Setting
{
    public static class AppSetting
    {
        public static string url;

        private static ISettings AppSettings => CrossSettings.Current;

        public static Dictionary<string, string> AppData = appData;
        private static Dictionary<string, string> appData 
        {
            get => JsonConvert.DeserializeObject<Dictionary<string, string>>(AppSettings.GetValueOrDefault(nameof(appData), JsonConvert.SerializeObject(new Dictionary<string, string>())));
            set => AppSettings.AddOrUpdateValue(nameof(appData), JsonConvert.SerializeObject(value));
        }

        public static void UpdateAppData()
        {
            appData = AppData;
        }
    }
}
