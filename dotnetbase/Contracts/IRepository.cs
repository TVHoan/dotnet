namespace dotnetbase.Contracts;

public interface IRepository<TEntity>
{
    Task<List<TEntity>> GetListAsync();
    
    Task<TEntity?> GetAsync(Guid id);

    IQueryable<TEntity> GetQueryable();
    
    void Insert(TEntity entity);
    
    void Update(TEntity entity);
    
    void Delete(TEntity entity);
    
    Task SaveChangesAsync();
}