using Domain.Common.BaseEntity;
using Domain.Entities.System;

namespace Domain.Entities.Business
{
    public class Notification : BaseEntitys<Guid>
    {

        public Guid UserId { get; set; }
        public string Type { get; set; } = null!;
        public Guid? ReferenceId { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }


        public ApplicationUser User { get; set; } = null!;
    }
}
