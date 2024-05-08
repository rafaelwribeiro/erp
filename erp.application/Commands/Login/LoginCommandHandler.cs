using erp.domain.Abstractions;
using erp.domain.Entities;
using MediatR;
using erp.application.ExtensionUtils;
using erp.domain.Exceptions;

namespace erp.application.Commands.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommand, User>
{
    private readonly IUserRepository _userRepository;

    public LoginCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByFilter(u => u.Username.ToLower().Equals(request.Username.ToLower()));
        
        if (!request.Password.VerifyPassword(user?.Password ?? "123".EncryptPassword()))
            throw new BusinessRuleException("User not found or wrong password");
        
        return user;
    }
}
