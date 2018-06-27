using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Models.View
{
    public class QuestItem
    {
        public string Id;
        public string Title { get; set; }

        public string CityId;
        public string City { get; set; }

        public string Logo { get; set; }

        public int StarsCount = 5;
        public string BackgroundUrl { get; set; }

        public Color TabColor { get; set; } = Color.CadetBlue;

        public string Price { get; set; } = "Free";
    }
}
