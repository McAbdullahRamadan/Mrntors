using Domain.Common.BaseEntity;
using Domain.Entities.System;

namespace Domain.Entities.Business
{
    public class ConversationParticipant : BaseEntitys<Guid>
    {
        public Guid ConversationId { get; set; }
        public Guid UserId { get; set; }


        public Conversation Conversation { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
    }
}
