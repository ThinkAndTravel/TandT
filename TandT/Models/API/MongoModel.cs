using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Models.API
{
    public class MongoModel
    {
        [BsonId]
        public string _id { get; set;}
    }
}
