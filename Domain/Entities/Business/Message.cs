using Domain.Common.BaseEntity;
using Domain.Entities.System;

namespace Domain.Entities.Business
{
    public class Message : BaseEntitys<Guid>
    {

        public Guid ConversationId { get; set; }
        public Guid SenderId { get; set; }
        public string? Content { get; set; }
        public string? MediaUrl { get; set; }
        public DateTime CreatedAt { get; set; }


        public Conversation Conversation { get; set; } = null!;
        public ApplicationUser Sender { get; set; } = null!;
    }
}
