using System.Collections.Generic;

namespace Models.API
{
    public class Quest:MongoModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Logo { get; set; }

        public List<string> DescriptionPhotos { get; set; } 

        public List<string> Tasks { get; set; }

        public List<string> Tags { get; set; }

        public string AuthorId { get; set; }



    }
}
