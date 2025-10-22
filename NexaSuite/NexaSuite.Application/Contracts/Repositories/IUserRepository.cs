using NexaSuite.Domain.Users;

namespace NexaSuite.Application.Contracts.Repositories;

public interface IUserRepository
{
    Task<User> AddAsync(User user, CancellationToken cancellationToken = default);
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default);
}
