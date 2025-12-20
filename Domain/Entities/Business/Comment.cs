using Domain.Common.BaseEntity;
using Domain.Entities.System;

namespace Domain.Entities.Business
{

    public class Comment : BaseEntitys<Guid>
    {

        public Guid UserId { get; set; }
        public Guid PostId { get; set; }
        public Guid? ParentCommentId { get; set; }
        public string Content { get; set; } = null!;
        public DateTime CreatedAt { get; set; }


        public ApplicationUser User { get; set; } = null!;
        public Post Post { get; set; } = null!;
        public Comment? ParentComment { get; set; }
        public ICollection<Comment> Replies { get; set; } = new List<Comment>();
    }
}
