using Domain.Common.BaseEntity;
using Domain.Entities.System;

namespace Domain.Entities.Business
{
    public class StoryView : BaseEntitys<Guid>
    {

        public Guid StoryId { get; set; }
        public Guid UserId { get; set; }
        public DateTime ViewedAt { get; set; }


        public Story Story { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
    }
}
