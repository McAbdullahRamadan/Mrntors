using Domain.Common.BaseEntity;
using Domain.Entities.System;

namespace Domain.Entities.Business
{
    public class Follow : BaseEntitys<Guid>
    {

        public string? FollowerId { get; set; }
        public string? FollowingId { get; set; }
        public string Status { get; set; } = "accepted";


        public ApplicationUser Follower { get; set; } = null!;
        public ApplicationUser Following { get; set; } = null!;
    }
}
