using Domain.Common.BaseEntity;

namespace Domain.Entities.Business
{
    public class Conversation : BaseEntitys<Guid>
    {

        public bool IsGroup { get; set; }
        public DateTime CreatedAt { get; set; }


        public ICollection<ConversationParticipant> Participants { get; set; } = new List<ConversationParticipant>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}
