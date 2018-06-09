using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace TandT
{
    public static class AppSetting
    {
        private static ISettings AppSettings {
            get {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        #endregion


        public static string GeneralSettings {
            get {
                return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
            }
            set {
                AppSettings.AddOrUpdateValue(SettingsKey, value);
            }
        }

    }
}

