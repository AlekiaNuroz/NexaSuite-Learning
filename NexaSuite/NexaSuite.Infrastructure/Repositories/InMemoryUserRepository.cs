using NexaSuite.Application.Contracts.Repositories;
using NexaSuite.Domain.Users;

namespace NexaSuite.Infrastructure.Repositories;

public class InMemoryUserRepository : IUserRepository
{
    private readonly List<User> _users = [];

    public Task<User> AddAsync(User user, CancellationToken cancellationToken = default)
    {
        _users.Add(user);
        return Task.FromResult(user);
    }

    public Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        return Task.FromResult(user);
    }

    public Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult(_users.ToList());
    }
}
