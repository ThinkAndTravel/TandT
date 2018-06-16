using System;

namespace Models.View
{
    public class News
    {
        #region VAR
        
        public string Id { get; set; }
        
        public string UserName { get; set; }
        
        public string UserId { get; set; }
        
        public string Time { get; set; }
        
        public string Text { get; set; }
        
            public string PhotoUrl { get; set; }
        
        public string LikesValue { get; set; }
        
        public string CommentValue { get; set; }
        
        public bool UserLikeNews { get; set; }
        
        #endregion
    }
}