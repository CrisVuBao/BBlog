namespace BBlogApi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string BlogUserId { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
