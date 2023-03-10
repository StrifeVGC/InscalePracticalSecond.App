namespace InscalePracticalSecond.Domain.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public List<string> Tags { get; set; }
        public int Reactions { get; set; }
    }
}
