using System;
using System.Collections.Generic;
using System.Text;

namespace Models.API
{
    public class TaskCompletionRequest : MongoModel
    {
        public string UserID { get; set; }

        public string TaskID { get; set; }

        public string QuestID { get; set; }

        public double GeoLong { get; set; }

        public double GeoLat { get; set; }

        /// <summary>
        /// 1 - geoLocation
        /// 2 - photo
        /// 3 - test
        /// 4 - geoLoc+photo
        /// 5 - geoLoc+test
        /// 6 - Photo+test
        /// 7 - geoLoc+Photo+test
        /// </summary>
        public int ConfirmMethod { get; set; }

        public string PhotoId { get; set; }

        public List<string> Answer { get; set; }

    }
}
