using BLL.Setting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BLL
{
    public static class AuthService
    {
        public static async Task<bool> Login(string email, string password)
        {
            //TODO API
            return true;
        }

        public static bool Logged 
        {
            get  
            {                
               return AppSetting.AppData.ContainsKey("email");
            }
        }

        public static async Task Registration(Dictionary<string, string> data)
        {
            //TODO API 
        }

        #region Session

        public static void CloseSession()
        {
            try
            {
                AppSetting.AppData.Remove("email");
                AppSetting.AppData.Remove("password");
                AppSetting.UpdateAppData();
            }
            catch
            {
                Debug.Write("#### error close session");
            }
        }

        public static void NewSession(string Email, string Password)
        {
            if (AppSetting.AppData.ContainsKey("email"))
            {
                AppSetting.AppData["email"] = Email;
                AppSetting.AppData["password"] = Password;
            }
            else
            {
                AppSetting.AppData.Add("email", Email);
                AppSetting.AppData.Add("password", Password);
            }
            AppSetting.UpdateAppData();
        }

       

        #endregion
    }
}
