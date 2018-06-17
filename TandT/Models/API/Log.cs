using System;
using System.Collections.Generic;
using System.Text;

namespace Models.API
{
    public class Log : MongoModel
    {
        public DateTime date{ get; set;}
        public string type { get; set;}
        public string About { get; set; }
    }
}
