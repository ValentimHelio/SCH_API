using Api.Domain.Entities;
using System.Linq.Expressions;

namespace Api.Domain.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
    Task<IEnumerable<T>> SelectAsync();
    Task<T?> SelectAsync(Expression<Func<T, bool>> predicate);
    T InsertAsync(T entity);
    T UpdateAsync(T entity);
    bool DeleteAsync(int id);
}
