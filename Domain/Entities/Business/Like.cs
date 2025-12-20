using Domain.Common.BaseEntity;
using Domain.Entities.System;

namespace Domain.Entities.Business
{
    public class Like : BaseEntitys<Guid>
    {

        public Guid UserId { get; set; }
        public Guid PostId { get; set; }
        public DateTime CreatedAt { get; set; }


        public ApplicationUser User { get; set; } = null!;
        public Post Post { get; set; } = null!;
    }
}
