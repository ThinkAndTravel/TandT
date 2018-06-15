using Newtonsoft.Json;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class UserSetting
    {
        private static ISettings AppSettings => CrossSettings.Current;

        private static Dictionary<string, string> data = Data;
        public  static Dictionary<string, string> Data 
        {
            get => JsonConvert.DeserializeObject<Dictionary<string, string>>(AppSettings.GetValueOrDefault( nameof(Data), JsonConvert.SerializeObject(new Dictionary<string, string>()) ));
            set => AppSettings.AddOrUpdateValue(nameof(Data), JsonConvert.SerializeObject(value));
        }

        public static void UpdateData()
        {
            Data = data;
        }

        #region Session

        public static void CloseSession()
        {
            data.Remove("email");
            data.Remove("password");
            UpdateData();
        }

        public static void NewSession(string Email, string Password)
        {
            if (data.ContainsKey("email"))
            {
                data["email"] = Email;
                data["password"] = Password;
            }
            else
            {
                data.Add("email", Email);
                data.Add("password", Password);
            }
            UpdateData();
        }

        public static async Task Registration(Dictionary<string, string> data)
        {
            
        }
       
        #endregion
    }
}
