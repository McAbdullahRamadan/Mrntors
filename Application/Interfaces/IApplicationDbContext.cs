using Domain.Entities.Business;
using Domain.Entities.System;

namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<ApplicationUser> Users { get; }
        DbSet<Post> Posts { get; }
        DbSet<Comment> Comments { get; }
        DbSet<Like> Likes { get; }
        DbSet<Follow> Follows { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
