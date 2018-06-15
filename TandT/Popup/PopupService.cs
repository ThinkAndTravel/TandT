using System.Collections.Generic;

namespace Popup
{
    public static class PopupService
    {
        public static bool IsBusy = false;
        public static Dictionary<string, string> Data = new Dictionary<string, string>();

        public static bool AddNewParameters(Dictionary<string, string> data)
        {
            if (!IsBusy)
            {
                Data = data;
                IsBusy = true;
                return true;
            }
            return false;
        }

        public static void ReturnParameters(Dictionary<string, string> data)
        {
            if (IsBusy)
            {
                Data = data;
                IsBusy = false;              
            }
        }
    }
}
