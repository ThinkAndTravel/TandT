using System;
using System.Collections.Generic;
using System.Text;

namespace Models.API
{
    public class Task : MongoModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string AuthorId { get; set; }

        public double GeoLong { get; set; }

        public double GeoLat { get; set; }

        public double Radius { get; set; }

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

        public List<string> Tests { get; set; }
        
        /// <summary>
        /// 1 - Common
        /// 2 - partner's
        /// 3 - user's
        /// </summary>
        public int Role { get; set; }
    }
}
