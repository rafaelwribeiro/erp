using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.domain.Exceptions;
using Mapster;
using MediatR;
using erp.application.ExtensionUtils;

namespace erp.application.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, User>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateUserCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = request.Adapt<User>();

        await VerifyUserNameAlreadyExists(user.Username);

        user.Password = user.Password.EncryptPassword();

        var createdUser = await _unitOfWork.UserRepository.Add(user);

        await _unitOfWork.CommitAsync();

        return createdUser;
    }

    private async Task VerifyUserNameAlreadyExists(string username)
    {
        var repo = _unitOfWork.UserRepository;
        var exists = await repo.AnyByFilter(x => x.Username.ToLower().Equals(username.ToLower()));
        if (exists)
            throw new BusinessRuleException($"the username {username} already exists");
    }
}
