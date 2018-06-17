using Newtonsoft.Json.Linq;
using System;

namespace Models.View
{
    public class NewsItem
    {
        #region VAR

        public string Id { get; set; } = "";
        
        public string UserName { get; set; } = "Славік";
        public string Avatar { get; set; } = "user.png";

        public string UserId { get; set; } = "@lvanenko";

        public string Time { get; set; } = "10 хв тому";

        public string Text { get; set; } = "всім привіт))) це моя перша новина) надіюсь мені вдасться відобразити все нормально) ";

        public string PhotoUrl { get; set; } = "";
        public string LikesValue { get; set; } = "10";
        public string LikeSource 
        {
            get { return UserLikeNews ? "like.png" : "unlike.png"; }
        }

        public string CommentValue { get; set; } = "4";

        public bool UserLikeNews  = true;

        #endregion

        //public News(JToken token)
        //{

        //}
    }
}