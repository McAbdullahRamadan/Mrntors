using Infrastructure.ApplicationsDbContext;
using MediatR;

namespace Infrastructure
{
    public class TransactionBehavior<TRequest, TResponse>
      : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly ApplicationDbContext _context;

        public TransactionBehavior(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TResponse> Handle(
            TRequest request,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken)
        {
            await using var transaction =
                await _context.Database.BeginTransactionAsync(cancellationToken);

            var response = await next();

            await transaction.CommitAsync(cancellationToken);

            return response;
        }
    }
}
