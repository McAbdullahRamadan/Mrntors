using Domain.Common.BaseEntity;

namespace Domain.Entities.Business
{
    public class PostMedia : BaseEntitys<Guid>
    {

        public Guid PostId { get; set; }
        public string MediaUrl { get; set; } = null!;
        public string MediaType { get; set; } = null!; // image / video
        public int OrderIndex { get; set; }


        public Post Post { get; set; } = null!;
    }
}
