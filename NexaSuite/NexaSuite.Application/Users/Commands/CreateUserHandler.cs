using MediatR;
using NexaSuite.Application.Users.DTOs;
using NexaSuite.Domain.Users;

namespace NexaSuite.Application.Users.Commands;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserDto>
{
    public Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        // Domain entity creation
        var user = new User(request.Name, request.Email);

        // Normally we'd persist via repository (coming in Step 4)
        // For now, just map to DTO
        var dto = new UserDto
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Roles = user.Roles.ToList()
        };

        return Task.FromResult(dto);
    }
}
