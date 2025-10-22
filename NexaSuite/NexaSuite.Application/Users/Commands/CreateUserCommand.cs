using MediatR;
using NexaSuite.Application.Users.DTOs;

namespace NexaSuite.Application.Users.Commands;

public record CreateUserCommand(string Name, string Email) : IRequest<UserDto>;
