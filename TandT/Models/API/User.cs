using System.Collections.Generic;

namespace Models.API
{
    public class User:MongoModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string HashPass { get; set; }

        public string Avatar { get; set; }
       
        public List<KeyValuePair<string,int>> Quests { get; set; }

        /// <summary>
        /// 1 - admin
        /// 2 - partner
        /// 3 - user
        /// </summary>
        public int Role { get; set; }
    }
}
