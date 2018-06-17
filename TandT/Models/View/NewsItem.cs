using Newtonsoft.Json.Linq;
using System;

namespace Models.View
{
    public class NewsItem
    {
        #region VAR

        public string Id { get; set; } = "";
        
        public string UserName { get; set; } = "Славік";

        public string UserId { get; set; } = "";

        public string Time { get; set; } = "10 хв тому";

        public string Text { get; set; } = "всім привіт))) це моя перша новина) надіюсь мені вдасться відобразити все нормально) ";

        public string PhotoUrl { get; set; } = "https://ru.wikipedia.org/wiki/%D0%A4%D0%BE%D0%BD_(%D0%98%D1%80%D0%BB%D0%B0%D0%BD%D0%B4%D0%B8%D1%8F)#/media/File:Fahan_Old_Church_1996_08_29.jpg";

        public string LikesValue { get; set; } = "10";

        public string CommentValue { get; set; } = "4";

        public bool UserLikeNews { get; set; } = true;

        #endregion

        //public News(JToken token)
        //{

        //}
    }
}