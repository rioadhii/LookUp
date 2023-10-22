namespace LookUp.Application.Repositories;

public interface IUnitOfWork
{
    Task Save(CancellationToken token);
}