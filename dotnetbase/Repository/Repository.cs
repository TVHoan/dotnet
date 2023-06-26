using dotnetbase.Data;
using Microsoft.EntityFrameworkCore;

namespace dotnetbase.Repository;

public class Repository<TEntity> : IRepository<TEntity>
where TEntity : class
{
    private readonly ApplicationDbContext _context;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<TEntity>> GetListAsync()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity?> GetAsync(Guid id)
    {
        return await _context.Set<TEntity>().FindAsync(id);
    }

    public  IQueryable<TEntity> GetQueryable()
    {
        return  _context.Set<TEntity>().AsQueryable();
    }

    public  void Insert(TEntity entity)
    {
         _context.Set<TEntity>().Add(entity);
    }

    public  void Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
    }

    public  void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}