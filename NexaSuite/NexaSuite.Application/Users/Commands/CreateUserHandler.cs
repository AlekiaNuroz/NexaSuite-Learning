using MediatR;
using NexaSuite.Application.Users.DTOs;
using NexaSuite.Application.Contracts.Repositories;
using NexaSuite.Domain.Users;

namespace NexaSuite.Application.Users.Commands;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserDto>
{
    private readonly IUserRepository _repository;

    public CreateUserHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        // Create the domain entity
        var user = new User(request.Name, request.Email);

        // Persist the new user
        await _repository.AddAsync(user, cancellationToken);

        // Map to DTO
        return new UserDto
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Roles = user.Roles.ToList()
        };
    }
}
