using System;
using System.Collections.Generic;
using System.Text;

namespace Models.API
{
    public class Photo : MongoModel
    {
        public string Url { get; set; }
    }
}
