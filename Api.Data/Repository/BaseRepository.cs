using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Api.Data.Repository;

public class BaseRepository<T> : IRepository<T> where T : BaseEntity
{
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> SelectAsync()
    {
        return await _context.Set<T>().AsNoTracking().ToListAsync();
    }

    public async Task<T?> SelectAsync(Expression<Func<T, bool>> predicate)
    {
        return await _context.Set<T>().FirstOrDefaultAsync(predicate);
    }

    public T InsertAsync(T entity)
    {
        entity.CreateAt = DateTime.Now;
        entity.IsDeleted = false;
        _context.Set<T>().Add(entity);
        return entity;
    }

    public T UpdateAsync(T entity)
    {
        var result = _context.Set<T>().SingleOrDefault(x => x.Id == entity.Id);
        if (result is null) return null;
        result.UpdateAt = DateTime.UtcNow;
        entity.CreateAt = result.CreateAt;
        _context.Entry(result).CurrentValues.SetValues(entity);
        //_context.Set<T>().Update(entity);
        return entity;
    }

    public bool DeleteAsync(int id)
    {
        var result = _context.Set<T>().SingleOrDefault(x => x.Id == id);
        if (result is null) return false;
        result.UpdateAt = DateTime.UtcNow;
        result.IsDeleted = true;
        _context.Set<T>().Update(result);
        return true;
    }
}
