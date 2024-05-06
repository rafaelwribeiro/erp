using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.CreateUser;

public class CreateUserCommand : IRequest<User>
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
