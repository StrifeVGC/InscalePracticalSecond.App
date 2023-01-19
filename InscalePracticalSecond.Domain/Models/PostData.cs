using System.ComponentModel.DataAnnotations;

namespace InscalePracticalSecond.Domain.Models
{
    public class PostData
    {
        [Key]
        public int Id { get; set; }
        public int PostId { get; set; }
        public string UserName { get; set; }
        public bool HasFrenchTag { get; set; }
        public bool HasFictionTag { get; set; }
        public bool HasMoreThanTwoReactions { get; set; }
    }
}
