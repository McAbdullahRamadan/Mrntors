using Domain.Common.BaseEntity;
using Domain.Entities.System;

namespace Domain.Entities.Business
{
    public class Post : BaseEntitys<Guid>
    {

        public Guid UserId { get; set; }
        public string? Caption { get; set; }
        public DateTime CreatedAt { get; set; }


        public ApplicationUser User { get; set; } = null!;
        public ICollection<PostMedia> Media { get; set; } = new List<PostMedia>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Like> Likes { get; set; } = new List<Like>();
    }
}
