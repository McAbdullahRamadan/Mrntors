using Domain.Entities.Business;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.System
{
    public class ApplicationUser : IdentityUser
    {
        public string? Bio { get; set; }
        public string? ProfileImage { get; set; }
        public bool IsPrivate { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<Story> Stories { get; set; } = new List<Story>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Like> Likes { get; set; } = new List<Like>();


        public ICollection<Follow> Followers { get; set; } = new List<Follow>();
        public ICollection<Follow> Following { get; set; } = new List<Follow>();

        public ICollection<ConversationParticipant> Conversations { get; set; } = new List<ConversationParticipant>();
        public ICollection<Message> MessagesSent { get; set; } = new List<Message>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    }
}
