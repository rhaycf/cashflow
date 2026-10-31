using CashFlow.Domain.Repositories;
using CashFlow.Domain.Repositories.User;
using CashFlow.Domain.Services.LoggedUser;

namespace CashFlow.Application.UseCases.Users.Delete;

public class DeleteUserAccountUseCase : IDeleteUserAccountUseCase
{
    IUnitOfWork _unitOfWork;
    IUserWriteOnlyRepository _repository;
    ILoggedUser _loggedUser;

    public DeleteUserAccountUseCase(IUnitOfWork unitOfWork, IUserWriteOnlyRepository repository, ILoggedUser loggedUser)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _loggedUser = loggedUser;
    }

    public async Task Execute()
    {
        var user = await _loggedUser.Get();

        await _repository.Delete(user);

        await _unitOfWork.Commit();
    }
}
