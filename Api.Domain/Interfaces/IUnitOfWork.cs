namespace Api.Domain.Interfaces;

public interface IUnitOfWork
{
    Task CommitAsync();
}
