using Datos.Contexts;
using System.Linq.Expressions;

public abstract class RepositoryPrueba<T> : IRepositoryPrueba<T> where T : class
{
    AppDbContext _context;

    public RepositoryPrueba (AppDbContext context)
    {
        _context = context;
    }

    public bool Save()
    {
        return _context.SaveChanges() > 0;
    }

    public void Create(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression).ToList();
    }

    public T FindByID(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public IEnumerable<T> FindAll()
    {
        return _context.Set<T>().ToList();
    }
}