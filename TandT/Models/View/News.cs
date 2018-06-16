using System;

namespace Models.View
{
    public class News
    {
        #region VAR

        public string Id { get; set; } = "";
        
        public string UserName { get; set; } = "СЛВК";

        public string UserId { get; set; } = "";

        public string Time { get; set; } = "10 хв тому";

        public string Text { get; set; } = "всім привіт)))";

        public string PhotoUrl { get; set; } = "";

        public string LikesValue { get; set; } = "10";

        public string CommentValue { get; set; } = "4";

        public bool UserLikeNews { get; set; } = true;

        #endregion
    }
}